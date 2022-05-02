# Amped five software localisation

In this project we just want to localise the [software](https://ampedsoftware.com/five). Then we added the docs in the persian language and provide an `.mo` file which responsible for the localising stuff. At last we came up with a patch to replace all of the necessary files in the installed software directory.

## How we patched the software

Since the software was not available in open-source and all of the files were in `.dll` format which was the compiled version of the software for the machine itself. We had to patch the software and replace the existing language which we choose Arabic with the persian one. So all we did for patching it was to replace the Arabic language files and docs with the persian one.
