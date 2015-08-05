# Build Instructions #

If you want the GUI with syntax highlighting and you're building tf4mono youreself, configure tf4mono as follows:

> ./configure --prefix=/usr --enable-highlight

You should see something like:

```
Configuration Summary
----------------------------------
  File Type Support:  yes
  Man Page Generation:  yes
  Gnome Keyring Support:  no
  Gui Support:  yes
  Syntax Highlighting:  yes
```

If you see "no" for Gui support, you need to install gtk-sharp. Syntax highlighting requires libgnome-vfs2.0-cil and libgtksourceview2.0-cil.

If your output looks like the above, then build and install
tf4mono with "make all install"

You can run the gui mode by executing "tf explore" in a
workfolder managed by tf, or by executing "tf explore
/server:

&lt;ip-address&gt;

".






