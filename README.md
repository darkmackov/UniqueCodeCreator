# UniqueCodeCreator

## Description
**This application was originally developed for personal testing and use, but I decided to share it with others who might find an application like this useful.**

This is a simple Windows application that generates unique codes based on a specified number of characters, with an optional prefix and suffix added to each code.
While the generated codes are not globally unique (not UUIDs), they are unique within the context of a single generation session. The application uses a random number generator to create combinations of characters from a predefined character set or numeric set.
These combinations are then checked using a HashSet to ensure that no duplicates are produced during a generation cycle.

## Translation
The application supports multiple languages. It automatically detects and uses the system language on startup. Currently supported languages:
- English
- Czech

## Usage Notes
Feel free to use the application as-is or modify it to suit your needs. If you have feature request or encounter any issues, feel free to contact me or open an issue with your suggestion.