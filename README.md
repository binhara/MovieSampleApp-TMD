# MovieSampleApp-TMD
This is a sample aplication in Xamarin.Forms + Prims + Unity + Nunit Tests

To perform the build open the solution in Visual Studio 2017. This solution has not been tested in previous VisualStudio versions of VisualStudio.
Perform a cleaning in Solution
Do not forget to update all Nugget packages

Libraries:
* Xamarin.Form - To build the crossplatform user interface.
* Newtonsoft.Json - work as the searelization of objects / Json
* HttpClient - for access to Rest we use the implementation of HTTPclient from Microsoft.
* Prims - As MVVM frameworks we use Prism
* Prims.Forms - To integrate the screens created in XAMM Xamarin.Forms
* Prims.Unity - DIP - as dependency ingetor framework.


The Solution :
* ClassLibrary - Project containing access layer to access Rest to The Database Movie
* ClassLibrary.Test - Automated test solution that tests the access layer to Rest and some behaviors and functionality of the App
* MovieApp - Project and contains the Xamarin.Forms application
* MovieApp.Droid - Project that generates the android applications, and where will be found the specialized native code for Android.
* MovieApp.iOs - Project that generates iOS applications, and where specialized native iOS code will be found.


