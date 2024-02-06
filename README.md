# MAUI Incorrect Theme when Resuming iOS App
Maui is using `Light Theme` instead of `Dark Theme` on iOS when resuming App (for example after "sharing a link" to a browser) when the OS is set to use Dark Theme (and the app was showing Dark Theme before resuming.
`Application.Current.RequestedTheme` is also returning the incorrect theme in these scenarios on `App.OnResume`.
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
