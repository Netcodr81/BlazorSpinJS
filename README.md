# BlazorSpinJS  projects

A spinner component built upon the [spin.js](https://spin.js.org/) package. A demo can be found in the *BlazorSpinJS.Server.Demo* and *BlazorSpinJS.WASM.Demo*

![Default Spinner Demo](https://user-images.githubusercontent.com/16604626/127219103-db49d989-4901-4d75-a53c-05acb78ed648.PNG)

![Default Configuration Demo](https://user-images.githubusercontent.com/16604626/127219132-72825f14-00f6-404d-9c7e-7655da545b5b.PNG)



## Getting Started

You can install the package via NugGet package manager just search for *BlazorSpinJS*. You can also intall via powershell using the following command.

```powershell
Install-Package BlazorSpinJS -Version 1.0.0
```
Or via the dotnet CLI.

```bash
dotnet add package BlazorSpinJS --version 1.0.0
```

### 1. Register Services
You will need to register the BlazorSpinJS service in your application

#### Blazor Server
Add the following line to your applications `Startup.ConfigureServices` method.

```csharp
public void ConfigureServices(IServiceCollection services)
{
    services.AddBlazorSpinner();
}
```

#### Blazor WebAssembly
Add the following line to your applications `Program.Main` method.

```csharp
builder.Services.AddBlazorSpinner();
```

### 2. Add Imports
Add the following to your *_Imports.razor*

```csharp
@using BlazorSpinJS.Components
@using BlazorSpinJS.Configuration
@using BlazorSpinJS.Services 
```

### 3. Registar and Configure the BlazorSpinJS component
Add the `<SpinnerContainer>` tag into your applications *App.razor*.

```csharp
<SpinnerContainer>
<Router AppAssembly="@typeof(Program).Assembly" PreferExactMatches="@true">
    <Found Context="routeData">
        <RouteView RouteData="@routeData" DefaultLayout="@typeof(MainLayout)" />
    </Found>
    <NotFound>
        <LayoutView Layout="@typeof(MainLayout)">
            <p>Sorry, there's nothing at this address.</p>
        </LayoutView>
    </NotFound>
</Router>
</SpinnerContainer>
```

### 4. Add references to style sheet(s)
Add the following line to the `head` tag of your `_Host.cshtml` (Blazor Server app) or `index.html` (Blazor WebAssembly).

```
 <link href="_content/BlazorSpinJS/blazor-spin.css" rel="stylesheet" />
 ```
 
 ## Usage
 In order to use the spinner you must inject the `ISpinnerService` into the component or service where you want to trigger the spinner. You can then call one of the following methods to stop and start the spinner.
 
 - `StartSpinner()`
 - `StopSpinner()`

## Spinner Configuration
Spinner position - you can make the spinner stay fixed in the middle of the screen when a user scrolls by setting the `IsFixed` parameter to true on the spinner component
```csharp
<SpinnerContainer IsFixed="true">
  <Router AppAssembly="@typeof(Program).Assembly" PreferExactMatches="@true">
    <Found Context="routeData">
        <RouteView RouteData="@routeData" DefaultLayout="@typeof(MainLayout)" />
    </Found>
    <NotFound>
        <LayoutView Layout="@typeof(MainLayout)">
            <p>Sorry, there's nothing at this address.</p>
        </LayoutView>
    </NotFound>
  </Router>
</SpinnerContainer>
```

You can configure any of the following spinner settings

- Lines
- Length
- Width
- Radius
- Scale
- Corners
- Speed
- Rotate
- Animation
- Direction
- Color
- FadeColor
- Top
- Left
- Shadow
- zIndex
- ClassName

by injecting a `SpinnerOptions` class into the *SpinnerOptions* parameter

```csharp
<SpinnerContainer IsFixed="true" SpinnerOptions="@(new SpinnerOptions(){
                                                     Lines= 1,
                                                     Length = 13,
                                                     Width = 6,
                                                     Radius = 12,
                                                     Scale = 1,
                                                     Corners = 1,
                                                     Speed = 1,
                                                     Rotate = 10,
                                                     Animation = Animation.FadeDefault.Value, 
                                                     Direction = SpinDirection.CounterClockwise.Value,
                                                     Color="#800000", 
                                                     FadeColor = "#FFFFFF",
                                                     Top = "50%",
                                                     Left = "50%",
                                                     Shadow = "0 0 1px transparent",
                                                     ZIndex = 200000000000,
                                                     ClassName = "spinner"
                                                 })">
    <Router AppAssembly="@typeof(Program).Assembly" PreferExactMatches="@true">
        <Found Context="routeData">
            <RouteView RouteData="@routeData" DefaultLayout="@typeof(MainLayout)" />
        </Found>
        <NotFound>
            <LayoutView Layout="@typeof(MainLayout)">
                <p>Sorry, there's nothing at this address.</p>
            </LayoutView>
        </NotFound>
    </Router>
</SpinnerContainer>
```
