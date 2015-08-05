Most of the unit tests require a working TeamFoundation server. Currently, the unit
tests use the following environment variables to configure which server, user account,
password, project, etc. to use for testing purposes.

export TFS\_URL=<url to server, eg. http://192.168.0.1:8080/>;

export TFS\_USERNAME=

&lt;your-username&gt;

;

export TFS\_DOMAIN=

&lt;your-domain&gt;

;

export TFS\_PASSWORD=

&lt;your-password&gt;

;

export TFS\_PROJECT=<a top-level project name, eg. MyProject>;

then you can do a "make run-tests"