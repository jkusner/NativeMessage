### OS X Manifest Instructions

* Download [com.nativemessage.example.json](./com.nativemessage.example.json)
* Place the file in one of the locations shown below
* Change the `path` inside of your manifest file to the **absolute path** where your executable is located

#### Manifest Location Table

Browser       | Install for   | Path 
:-------------|:--------------|:---------------------------------------------------------------------------
Google Chrome | All users     | /Library/Google/Chrome/NativeMessagingHosts/com.nativemessage.example.json
Google Chrome | Single user   | ~/Library/Application Support/Google/Chrome/NativeMessagingHosts/com.nativemessage.example.json
Chromium      | All users     | /Library/Application Support/Chromium/NativeMessagingHosts/com.nativemessage.example.json
Chromium      | Single user   | ~/Library/Application Support/Chromium/NativeMessagingHosts/com.nativemessage.example.json
