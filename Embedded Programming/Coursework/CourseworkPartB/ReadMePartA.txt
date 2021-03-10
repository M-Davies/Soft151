I. Use the potentiometer and the Analog to Digital Converter to periodically
measure data (from A0), at a precise rate of once every 0.1 seconds
(10Hz). [10%].

This was achieved in the Sample() function

II. Data shall be circular buffered and averaged over a one second window;
the average value is computed every time the buffer is updated. [20%]
III. Use PuTTY serial terminal to print the current sample and the current
average. [5%]

This was achieved in the Sample() function

IV. Extend the above as follows: when the external switch is pressed (D4),
the sampling stops and a new message appears on the terminal asking
for a new sampling rate. Then, the user types via keyboard the new
sampling rate. The sampling rate should be between 100Hz (0.01sec)
and 5Hz (0.2 sec); different rates should not be accepted by the program
(in this case the input rate has to be typed again). After successfully
providing the new sampling rate, the terminal should start printing the
new samples and averages (you don’t have to change the buffer’s size).
The Green led (D6) should always be flashing according to the sampling
rate. When the sampling stops, the red led (D7) will be turned on and
the green off. Make the appropriate choice between interrupts, threads
and synchronisation methods. Use appropriate methods to avoid string
buffer overflows. [40%]

This was achieved in the ButtonPressed() and RateChange() functions

V. Add extensions. Extensions to this task are left to you to decide. Please
note that the extensions must be related to the module’s contents
(interrupts, threads, synchronization, performance issues etc). An
example includes the case where the sampling does not stop by
pressing the switch (only the printing process stops); then the user can
sign in using a password and read, amend or change the size of the
buffer, change the sampling rate, delete the buffer’s contents etc. Think
of using the light dependent resistor too in order to read more input data.
[20%]

username = admin
password = password
A login system is in place in the Authentication() function but only works on the first button press. Afterwards, it rejects the correct username 

VI. Layout and formatting, structure of code, naming (of variables, functions
etc), sufficient comments. [5%]

Comments were added to all lines which needed them, variables were named using camel case and functions began with captial letters