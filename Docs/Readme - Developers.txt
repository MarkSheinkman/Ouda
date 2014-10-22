Hello developer! My name is Mark, i created Ouda and hopefully by the time you read this it has grown quite a bit.
In this doc im gonna tell you everything you need to know to make improvements and changes. Please update this file with any changes you make.

The purpose of Ouda is to save the data we collect on the public health project so that we can analyze it, see statistics, and maybe submit it to Ghana's e-health system. The data is saved as XML files for easy reading/writing, code-wise it's just a simple deserialization of a POCO.

To keep the program usable and prevent it from becoming a burdon, it needs to be very quick and fluent. The main purpose is data entry, so that needs to be as easy as possible. Currently, it's as simple as:
enter value
TAB
enter value
TAB
...
enter last value
TAB
ENTER
saved, ready for next
