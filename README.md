# Control for IBM i®

This is a small control app for the api-exitpoints at my cgi-examples<br>
Coded in vb.net, using newtonsoft json parser<br><br>
Version 0.1.12<br><br>
Based on the examples from my cgi-serviceprogram "https://github.com/PantalonOrange/CGI-Serviceprogram"

# Active jobs (for API GETACTJOB.sqlrpgle)
![activejobs](https://github.com/PantalonOrange/Control-for-IBM-i/blob/main/actjob.PNG)


# User profile informations (for API GETUSRINF.sqlrpgle)
![userinfos](https://github.com/PantalonOrange/Control-for-IBM-i/blob/main/usrinf.PNG)

# IBMi HTTP-Server:
Change the settings:
```
# common system webservices
ScriptAlias /system/activejobs /qsys.lib/youtlib.lib/getactjob.pgm
ScriptAlias /system/replys /qsys.lib/youtlib.lib/getactjob.pgm
ScriptAlias /system/endjobs /qsys.lib/youtlib.lib/getactjob.pgm
ScriptAlias /system/executecommands /qsys.lib/youtlib.lib/getactjob.pgm
ScriptAlias /system/userinfos /qsys.lib/youtlib.lib/getusrinf.pgm
ScriptAlias /system/usercheck /qsys.lib/youtlib.lib/getusrinf.pgm
ScriptAlias /system/objectlocks /qsys.lib/youtlib.lib/getobjlck.pgm
ScriptAlias /system/objectstatistics /qsys.lib/youtlib.lib/getobjinf.pgm
ScriptAlias /system/historylogs /qsys.lib/youtlib.lib/gethstlog.pgm
ScriptAlias /system/joblogs /qsys.lib/youtlib.lib/getjoblog.pgm
ScriptAlias /system/outqs /qsys.lib/youtlib.lib/getoutinf.pgm
ScriptAlias /system/outqentries /qsys.lib/youtlib.lib/getoutent.pgm
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