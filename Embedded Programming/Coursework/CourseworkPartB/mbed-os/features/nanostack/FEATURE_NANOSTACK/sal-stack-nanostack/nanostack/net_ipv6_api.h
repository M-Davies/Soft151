/*
 * Copyright (c) 2016 ARM Limited. All rights reserved.
 *
 * SPDX-License-Identifier: LicenseRef-PBL
 *
 * Licensed under the Permissive Binary License, Version 1.0 (the "License"); you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * https://www.mbed.com/licenses/PBL-1.0
 *
 * See the License for the specific language governing permissions and limitations under the License.
 *
 */

/**
 * \file net_ipv6_api.h
 * \brief IPv6 configuration API.
 */

#ifndef NET_IPV6_API_H_
#define NET_IPV6_API_H_

#include "ns_types.h"

/**
 * \brief Set maximum IPv6 fragmented datagram reception size.
 *
 * Set the maximum size limit for fragmented datagram reception.
 *
 * RFC 2460 requires this to be at least 1500. It should also be at least
 * as large as the MTU of each attached link.
 *
 * \param frag_mru The fragmented Maximum Receive Unit in octets.
 * \return 0 Change OK - actual MRU is at least the requested value.
 * \return <0 Change invalid - unable to set the specified MRU.
 */
int8_t arm_nwk_ipv6_frag_mru(uint16_t frag_mru);

/**
 * \brief Configure automatic flow label calculation.
 *
 * Enable or disable automatic generation of IPv6 flow labels for outgoing
 * packets.
 *
 * \param auto_flow_label True to enable auto-generation.
 */
void arm_nwk_ipv6_auto_flow_label(bool auto_flow_label);

/**
 * \brief Set the key for opaque IPv6 interface identifiers
 *
 * This call sets the secret key used to generate opaque interface identifiers,
 * as per RFC 7217. Once this has been set, all interfaces will use opaque
 * interface identifiers by default. If secret_key is NULL, opaque interface
 * identifiers will be disabled.
 *
 * Correct implementation of RFC 7217 would require that this key be
 * randomly generated at first bootstrap, and thereafter remain constant, which
 * would require non-volatile storage. The next closest alternative would be
 * to base this on a MAC address.
 *
 * \param secret_key A pointer to secret key (will be copied by call).
 * \param key_len The length of the key.
 *
 * \return 0 key set okay.
 * \return <0 key set failed (for example due to memory allocation).
 */
int8_t arm_nwk_ipv6_opaque_iid_key(const void *secret_key, uint8_t key_len);

/**
 * \brief Enable/disable opaque IPv6 interface identifiers by interface
 *
 * Enable or disable RFC 7217 opaque IIDs generated by SLAAC, per interface.
 * By default opaque IIDs are enabled if the opaque key is set. If disabled,
 * SLAAC IIDs will be EUI-64-based as per RFC 4291.
 *
 * \param interface_id Interface ID.
 * \param enable True to enable.
 * \return 0 enabled/disabled OK.
 * \return <0 failed (for example invalid interface ID).
 *
 */
int8_t arm_nwk_ipv6_opaque_iid_enable(int8_t interface_id, bool enable);

#endif /* NET_IPV6_API_H_ */
