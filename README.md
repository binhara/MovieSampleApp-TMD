# MovieSampleApp-TMD
This is a sample aplication in Xamarin.Forms + Prims + Unity + Nunit Tests

To perform the build open the solution in Visual Studio 2017. This solution has not been tested in previous VisualStudio versions.
* Perform a cleaning in Solution.
* Do not forget to update all Nugget packages.

Libraries:
* Xamarin.Form - Framework crossplatform user interface.
* Newtonsoft.Json - Framework  searelization of objects / Json
* HttpClient - Framework access Rest, use the implementation of HTTPclient from Microsoft.
* Prims - MVVM frameworks 
* Prims.Forms - Framework integrate the screens created in XAML Xamarin.Forms
* Prims.Unity - DIP - dependency ingetor framework.


The Solution :
* ClassLibrary - Project containing access layer Rest to The Database Movie
* ClassLibrary.Test - Automated test solution that tests the access layer to Rest and some behaviors and functionality of the App
* MovieApp - Project contains the Xamarin.Forms application
* MovieApp.Droid - Project generates the android application and the specialized native code for Android.
* MovieApp.iOs - Project that generates iOS application and a ative iOS code.


