/*
 * Copyright (c) 2016 ARM Limited. All rights reserved.
 * SPDX-License-Identifier: Apache-2.0
 * Licensed under the Apache License, Version 2.0 (the License); you may
 * not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an AS IS BASIS, WITHOUT
 * WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

#ifndef NANOSTACK_INTERFACE_H_
#define NANOSTACK_INTERFACE_H_

#include "mbed.h"
#include "NetworkStack.h"
#include "MeshInterface.h"
// Include here for backward compatibility
#include "LoWPANNDInterface.h"
#include "ThreadInterface.h"
#include "NanostackEthernetInterface.h"
#include "MeshInterfaceNanostack.h"

struct ns_address;

class NanostackInterface : public NetworkStack {
public:
    static NanostackInterface *get_stack();

protected:

    /** Get the local IP address
     *
     *  @return         Null-terminated representation of the local IP address
     *                  or null if not yet connected
     */
    virtual const char *get_ip_address();

    /** Opens a socket
     *
     *  Creates a network socket and stores it in the specified handle.
     *  The handle must be passed to following calls on the socket.
     *
     *  A stack may have a finite number of sockets, in this case
     *  NSAPI_ERROR_NO_SOCKET is returned if no socket is available.
     *
     *  @param handle   Destination for the handle to a newly created socket
     *  @param proto    Protocol of socket to open, NSAPI_TCP or NSAPI_UDP
     *  @return         0 on success, negative error code on failure
     */
    virtual nsapi_error_t socket_open(void **handle, nsapi_protocol_t proto);

    /** Close the socket
     *
     *  Closes any open connection and deallocates any memory associated
     *  with the socket.
     *
     *  @param handle   Socket handle
     *  @return         0 on success, negative error code on failure
     */
    virtual nsapi_error_t socket_close(void *handle);

    /** Bind a specific address to a socket
     *
     *  Binding a socket specifies the address and port on which to recieve
     *  data. If the IP address is zeroed, only the port is bound.
     *
     *  @param handle   Socket handle
     *  @param address  Local address to bind
     *  @return         0 on success, negative error code on failure.
     */
    virtual nsapi_error_t socket_bind(void *handle, const SocketAddress &address);

    /** Listen for connections on a TCP socket
     *
     *  Marks the socket as a passive socket that can be used to accept
     *  incoming connections.
     *
     *  @param handle   Socket handle
     *  @param backlog  Number of pending connections that can be queued
     *                  simultaneously
     *  @return         0 on success, negative error code on failure
     */
    virtual nsapi_error_t socket_listen(void *handle, int backlog);

    /** Connects TCP socket to a remote host
     *
     *  Initiates a connection to a remote server specified by the
     *  indicated address.
     *
     *  @param handle   Socket handle
     *  @param address  The SocketAddress of the remote host
     *  @return         0 on success, negative error code on failure
     */
    virtual nsapi_error_t socket_connect(void *handle, const SocketAddress &address);

    /** Accepts a connection on a TCP socket
     *
     *  The server socket must be bound and set to listen for connections.
     *  On a new connection, creates a network socket and stores it in the
     *  specified handle. The handle must be passed to following calls on
     *  the socket.
     *
     *  A stack may have a finite number of sockets, in this case
     *  NSAPI_ERROR_NO_SOCKET is returned if no socket is available.
     *
     *  This call is non-blocking. If accept would block,
     *  NSAPI_ERROR_WOULD_BLOCK is returned immediately.
     *
     *  @param server   Socket handle to server to accept from
     *  @param handle   Destination for a handle to the newly created socket
     *  @param address  Destination for the remote address or NULL
     *  @return         0 on success, negative error code on failure
     */
    virtual nsapi_error_t socket_accept(void *handle, void **server, SocketAddress *address);

    /** Send data over a TCP socket
     *
     *  The socket must be connected to a remote host. Returns the number of
     *  bytes sent from the buffer.
     *
     *  This call is non-blocking. If send would block,
     *  NSAPI_ERROR_WOULD_BLOCK is returned immediately.
     *
     *  @param handle   Socket handle
     *  @param data     Buffer of data to send to the host
     *  @param size     Size of the buffer in bytes
     *  @return         Number of sent bytes on success, negative error
     *                  code on failure
     */
    virtual nsapi_size_or_error_t socket_send(void *handle, const void *data, nsapi_size_t size);

    /** Receive data over a TCP socket
     *
     *  The socket must be connected to a remote host. Returns the number of
     *  bytes received into the buffer.
     *
     *  This call is non-blocking. If recv would block,
     *  NSAPI_ERROR_WOULD_BLOCK is returned immediately.
     *
     *  @param handle   Socket handle
     *  @param data     Destination buffer for data received from the host
     *  @param size     Size of the buffer in bytes
     *  @return         Number of received bytes on success, negative error
     *                  code on failure
     */
    virtual nsapi_size_or_error_t socket_recv(void *handle, void *data, nsapi_size_t size);

    /** Send a packet over a UDP socket
     *
     *  Sends data to the specified address. Returns the number of bytes
     *  sent from the buffer.
     *
     *  This call is non-blocking. If sendto would block,
     *  NSAPI_ERROR_WOULD_BLOCK is returned immediately.
     *
     *  @param handle   Socket handle
     *  @param address  The SocketAddress of the remote host
     *  @param data     Buffer of data to send to the host
     *  @param size     Size of the buffer in bytes
     *  @return         Number of sent bytes on success, negative error
     *                  code on failure
     */
    virtual nsapi_size_or_error_t socket_sendto(void *handle, const SocketAddress &address, const void *data, nsapi_size_t size);

    /** Receive a packet over a UDP socket
     *
     *  Receives data and stores the source address in address if address
     *  is not NULL. Returns the number of bytes received into the buffer.
     *
     *  This call is non-blocking. If recvfrom would block,
     *  NSAPI_ERROR_WOULD_BLOCK is returned immediately.
     *
     *  @param handle   Socket handle
     *  @param address  Destination for the source address or NULL
     *  @param data     Destination buffer for data received from the host
     *  @param size     Size of the buffer in bytes
     *  @return         Number of received bytes on success, negative error
     *                  code on failure
     */
    virtual nsapi_size_or_error_t socket_recvfrom(void *handle, SocketAddress *address, void *buffer, nsapi_size_t size);

    /** Register a callback on state change of the socket
     *
     *  The specified callback will be called on state changes such as when
     *  the socket can recv/send/accept successfully and on when an error
     *  occurs. The callback may also be called spuriously without reason.
     *
     *  The callback may be called in an interrupt context and should not
     *  perform expensive operations such as recv/send calls.
     *
     *  @param handle   Socket handle
     *  @param callback Function to call on state change
     *  @param data     Argument to pass to callback
     */
    virtual void socket_attach(void *handle, void (*callback)(void *), void *data);

    /*  Set stack-specific socket options
     *
     *  The setsockopt allow an application to pass stack-specific hints
     *  to the underlying stack. For unsupported options,
     *  NSAPI_ERROR_UNSUPPORTED is returned and the socket is unmodified.
     *
     *  @param handle   Socket handle
     *  @param level    Stack-specific protocol level
     *  @param optname  Stack-specific option identifier
     *  @param optval   Option value
     *  @param optlen   Length of the option value
     *  @return         0 on success, negative error code on failure
     */
    virtual nsapi_error_t setsockopt(void *handle, int level, int optname, const void *optval, unsigned optlen);

    /*  Get stack-specific socket options
     *
     *  The getstackopt allow an application to retrieve stack-specific hints
     *  from the underlying stack. For unsupported options,
     *  NSAPI_ERROR_UNSUPPORTED is returned and optval is unmodified.
     *
     *  @param handle   Socket handle
     *  @param level    Stack-specific protocol level
     *  @param optname  Stack-specific option identifier
     *  @param optval   Destination for option value
     *  @param optlen   Length of the option value
     *  @return         0 on success, negative error code on failure
     */
    virtual nsapi_error_t getsockopt(void *handle, int level, int optname, void *optval, unsigned *optlen);

private:
    nsapi_size_or_error_t do_sendto(void *handle, const struct ns_address *address, const void *data, nsapi_size_t size);
    char text_ip_address[40];
    static NanostackInterface * _ns_interface;
};

nsapi_error_t map_mesh_error(mesh_error_t err);

#endif /* NANOSTACK_INTERFACE_H_ */
