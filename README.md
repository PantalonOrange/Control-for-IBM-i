# Control for IBM i®

This is a small control app for the api-exitpoints at my cgi-examples<br>
Coded in vb.net, using newtonsoft json parser<br><br>
Version 0.1.14<br><br>
Based on the examples from my cgi-serviceprogram "https://github.com/PantalonOrange/CGI-Serviceprogram"

# All functions / windows
![userinfos](https://github.com/PantalonOrange/Control-for-IBM-i/blob/main/main.PNG)

# IBMi HTTP-Server:
Change the settings:
```
# common system webservices
ScriptAlias /system/activejobs /qsys.lib/yourlib.lib/getactjob.pgm
ScriptAlias /system/replys /qsys.lib/yourlib.lib/getactjob.pgm
ScriptAlias /system/endjobs /qsys.lib/yourlib.lib/getactjob.pgm
ScriptAlias /system/executecommands /qsys.lib/yourlib.lib/getactjob.pgm
ScriptAlias /system/userinfos /qsys.lib/yourlib.lib/getusrinf.pgm
ScriptAlias /system/usercheck /qsys.lib/yourlib.lib/getusrinf.pgm
ScriptAlias /system/objectlocks /qsys.lib/yourlib.lib/getobjlck.pgm
ScriptAlias /system/objectstatistics /qsys.lib/yourlib.lib/getobjinf.pgm
ScriptAlias /system/historylogs /qsys.lib/yourlib.lib/gethstlog.pgm
ScriptAlias /system/joblogs /qsys.lib/yourlib.lib/getjoblog.pgm
ScriptAlias /system/outqs /qsys.lib/yourlib.lib/getoutinf.pgm
ScriptAlias /system/outqentries /qsys.lib/yourlib.lib/getoutent.pgm
<Directory /qsys.lib/yourlib.lib>
  SetEnv QIBM_CGI_LIBRARY_LIST "YOURLIB;YAJL;QHTTPSVR;QGPL;QTEMP"
  AuthType Basic
  AuthName "system-apis"
  PasswdFile %%SYSTEM%%
  UserID %%CLIENT%%
  Require valid-user
  Order Deny,Allow
  Allow from 10.
  Deny from all
</Directory>
```