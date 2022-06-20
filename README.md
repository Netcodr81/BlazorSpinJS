# BlazorSpinJS  projects

A spinner component built upon the [spin.js](https://spin.js.org/) package. A demo can be found in the *BlazorSpinJS.Server.Demo* and *BlazorSpinJS.WASM.Demo*

![Default Spinner Demo](https://user-images.githubusercontent.com/16604626/127219103-db49d989-4901-4d75-a53c-05acb78ed648.PNG)

![Default Configuration Demo](https://user-images.githubusercontent.com/16604626/127219132-72825f14-00f6-404d-9c7e-7655da545b5b.PNG)



## Getting Started
**Note**: Breaking changes have been introduced in version 2.0.0. Version 2 is not compatible with applications running .NET 5. Make sure to use version 1.0.0 for any applications running .NET 5.
<br>
<Br>
You can install the package via NugGet package manager just search for *BlazorSpinJS*. You can also intall via powershell using the following command.
<br>
<br>


For .NET 5 Applications

```powershell
Install-Package BlazorSpinJS -Version 1.0.0
```

For .NET 6+ Applications

```powershell
Install-Package BlazorSpinJS -Version 2.0.0
```
<br>

Or via the dotnet CLI.
<br>

For .NET 5 Applications 

```bash
dotnet add package BlazorSpinJS --version 1.0.0
```
For .NET 6+ Applications

```bash
dotnet add package BlazorSpinJS --version 2.0.0
```
### 1. Register Services
You will need to register the BlazorSpinJS service in your application

#### Blazor Server
Add the following line to your applications `Startup.ConfigureServices` method.


```csharp
// Version 1.0.0

public void ConfigureServices(IServiceCollection services)
{
    services.AddBlazorSpinner();
}

// Version 2.0.0 - All configuration is now done when configuring the service using a SpinnerOptions class. 
// If a SpinnerOptions class is not used, the default settings will be applied.

builder.Services.AddBlazorSpinner();

// Or with the SpinnerOptionsClass

 builder.Services.AddBlazorSpinner(options =>
 {
     options.Color = "#61b551";
     options.Direction = SpinDirection.CounterClockwise;
     options.Position = Position.Fixed;

 });
   
```

#### Blazor WebAssembly
Add the following line to your applications `Program.Main` method.

```csharp
// Version 1.0.0

builder.Services.AddBlazorSpinner();

// Version 2.0.0 - All configuration is now done when configuring the service using a SpinnerOptions class. 
// If a SpinnerOptions class is not used, the default settings will be applied.

builder.Services.AddBlazorSpinner();

// Or with the SpinnerOptionsClass

 builder.Services.AddBlazorSpinner(options =>
 {
     options.Color = "#61b551";
     options.Direction = SpinDirection.CounterClockwise;
     options.Position = Position.Fixed;

 });


```

### 2. Add Imports
Add the following to your *_Imports.razor*

```csharp
// Version 1.0.0

@using BlazorSpinJS.Components
@using BlazorSpinJS.Configuration
@using BlazorSpinJS.Services 

// Version 2.0.0

@using BlazorSpinJS
@using BlazorSpinJS.Services
@using BlazorSpinJS.Components
@using BlazorSpinJS.Configuration
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
// Version 1.0.0

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

// Version 2.0.0 - The IsFixed parameter is no longer available. Use the Position.Fixed or Position.Absolute property of the SpinnerOptions class
// to configure the position.
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
- Position (version 2.0.0)

by injecting a `SpinnerOptions` class into the *SpinnerOptions* parameter

```csharp
// Version 1.0.0

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

// Version 2.0.0

 builder.Services.AddBlazorSpinner(options =>
 {
     options.Lines = 1;
	 options.Length = 13;
	 options.Width = 6;
	 options.Radius = 12;
	 options.Scale = 1;
	 options.Corners = 1;
	 options.Speed = 1;
	 options.Rotate = 10;
	 options.Animation = Animation.FadeDefault;
	 options.Direction = SpinDirection.CounterClockwise;
     options.Color = "#61b551";
	 options.FadeColor = "#FFFFFF";
	 options.Top = "50%";
	 options.Left = "50%";
	 options.Shadow = "0 0 1px transparent";
	 options.ZIndex = 200000000000;
	 options.ClassName = "spinner";
	 options.Position = Position.Fixed;    

 });

```
