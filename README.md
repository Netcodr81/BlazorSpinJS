# BlazorSpinJS

A spinner component built upon the [spin.js](https://spin.js.org/) package

Integration instructions coming soon

## Getting Started

You can install the package via NugGet package manager just search for *BlazorSpinJS*. You can also intall via powershell using the following command.

```powershell
Install-Package BlazorSpin
```
Or via the dotnet CLI.

```bash
dotnet add package BlazorSpinJS
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

You can configure the following spinner settings

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
<SpinnerContainer IsFixed="true" SpinnerOptions="@(new SpinnerOptions(){Color="#800000", 
                                                     Animation = Animation.FadeDefault.Value, 
                                                     Direction = SpinDirection.CounterClockwise.Value})">
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
