# NativeMessage

Native message wrappers for Google Chrome https://developer.chrome.com/extensions/nativeMessaging

Grab a wrapper and check out an example.

## Getting Started

### The Chrome Extension

* Download the [Chrome Extension Example](examples/chrome-extension)
* In Chrome go to _Settings -> Extensions_.
* Enable Developer Mode in the top right.
* Click _Load unpacked extension_
* Load the folder where you put the Chrome Extension Example
* You should now see the extension at the top of your extension page, copy the _extension ID_
* Now download and setup the [manifest files](for your operating system)
* Replace `chrome-extension://aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/` with `chrome-extension://{extension-ID}/`
* If you changed the name from _com.nativemessage.example_, make sure you changed it everywhere possible (including the JavaScript source in the chrome extension)
* Click the chrome extension icon at the top right of Google Chrome.
* If setup correctly, your application will launch
