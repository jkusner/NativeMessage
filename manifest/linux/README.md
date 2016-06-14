### Linux Manifest Instructions

* Download [examplemanifest.json](./examplemanifest.json)
* Place the file in one of the locations shown below (rename it to match the `name` defined inside)
* Change the `path` inside of your manifest file to the **absolute path** where your executable is located

#### Manifest Location Table

Browser       | Install for   | Path 
:-------------|:--------------|:---------------------------------------------------------------------------
Google Chrome | All users     | /etc/opt/chrome/native-messaging-hosts/com.nativemessage.example.json
Google Chrome | Single user   | ~/.config/google-chrome/NativeMessagingHosts/com.nativemessage.example.json
Chromium      | All users     | /etc/chromium/native-messaging-hosts/com.nativemessage.example.json
Chromium      | Single user   | ~/.config/chromium/NativeMessagingHosts/com.nativemessage.example.json
