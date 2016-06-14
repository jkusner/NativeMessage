### The Chrome Extension

The important parts are inside of [manifest.json](./manifest.json) and [popup.js](./popup.js)

#### Changing the name

* Make sure to change `"com.nativemessage.example"` in [popup.js](./popup.js)
* On Windows:
  * Change the registry key to the new name
* On Linux/OSX:
  * Change the _examplemanifest.json_ file name to the new name
* Change the `name` value inside of the _examplemanifest.json_ file

#### The connection

On the chrome side, Native Messages are very simple

To open a port and send/receive information, try something like this

```js
var port = chrome.runtime.connectNative("com.nativemessage.example")

// To send a message, call postMessage with an object
port.postMessage({
  msg: "abc",
  text: "123",
  thisCanBe: {
    aComplex: [
      "object"
    ]
  }
})

// To receive a message, add an onMessage listener with a callback
port.onMessage.addListener(function(msg) {
  console.log("Message received...")
  
  // Remember, msg is a regular object
  console.log(msg)
})

// You can also add other listeners, such as a disconnect listener
port.onDisconnect.addListener(function() {
  console.log("Lost connection!")
})
```

For more information and troubleshooting help, visit [Google's official guide](https://developer.chrome.com/extensions/nativeMessaging#native-messaging-host-manifest)
