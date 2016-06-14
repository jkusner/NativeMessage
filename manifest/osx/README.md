### OS X Manifest Instructions

* Download [examplemanifest.json](./examplemanifest.json)
* Place the file in one of the locations shown below (rename it to match the `name` defined inside)
* Change the `path` inside of your manifest file to the **absolute path** where your executable is located

#### Manifest Location Table

Browser       | Install for   | Path 
:-------------|:--------------|:---------------------------------------------------------------------------
Google Chrome | All users     | /Library/Google/Chrome/NativeMessagingHosts/com.nativemessage.example.json
Google Chrome | Single user   | ~/Library/Application Support/Google/Chrome/NativeMessagingHosts/com.nativemessage.example.json
Chromium      | All users     | /Library/Application Support/Chromium/NativeMessagingHosts/com.nativemessage.example.json
Chromium      | Single user   | ~/Library/Application Support/Chromium/NativeMessagingHosts/com.nativemessage.example.json
