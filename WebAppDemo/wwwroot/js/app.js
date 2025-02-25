// A few words about JSInterop
// communication JS <-> C#

function helloFromJavaScript(name) {
    alert(`This is JavaScript, hello ${name}`);
}

async function callCsharp() {
    let result = await DotNet.invokeMethodAsync("WebAppDemo", "GetProductJS", 1);
    console.log(result);
}

