# MAUI Incorrect Theme when Resuming iOS App
Maui uses Light Theme instead of Dark Theme on iOS when resuming App (for example after "sharing a link" to a browser).
It's sometimes needed to repeat Share process to reproduce the bug.

#### Steps to Reproduce:
1. Run App on iOS Device with the OS Theme set to Dark
2. Click on the Button and Share using a Browser
3. Go Back to App
4. Repeat from step 2 (until the App is showing Light Theme)

#### Result:
App shows Light Theme instead of Dark

#### Expected:
App should always use Dark Theme (which is the one used and requested by the OS)
