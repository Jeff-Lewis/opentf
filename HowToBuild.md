# Building Opentf on Win32 #
Currently, you can either use the opentf.sln soluion file and build
Opentf with VS2005 or VS2008, or install cygwin and follow the
instructions below for building opentf on **Nix.**

If you build with VS2005 or VS2008, the resulting opentf.exe TF client
will end up in tools/opentf/bin/.

# Building Opentf on **Nix #**

First, configure opentf:

> ./configure [--prefix=/yourprefix]

Valid options include:
```
    --disable-gtk           disable gtk gui support
    --enable-highlight      enable syntax highlighting support
    --disable-keyring       disable gnome keyring support                                 
    --disable-magic         disable libmagic file attributes
```
To build:

> make

To install:

> make install