window.addEventListener("load", function() {

  port = chrome.runtime.connectNative("com.johnkusner.nativemessagingtest")
  console.log("Port OPEN")
  console.log(port)

  port.onMessage.addListener(function(msg) {
    renderStatus(msg.text)
    console.log("Got Message:")
    console.log(msg)
  })
  port.onDisconnect.addListener(function() {
    renderStatus("Disconnected")
  })

  renderStatus("Waiting")

  msgNative("Hello from chrome")

  document.getElementById("sendbtn").addEventListener("click", function() {
    msgNative(document.getElementById("textbox").value)
  })
})

function renderStatus(statusText) {
  console.log(statusText)
  document.getElementById('response').innerText = statusText
}

function msgNative(msg) {
  console.log("Sending message: " + msg)
  port.postMessage({text:msg})
}