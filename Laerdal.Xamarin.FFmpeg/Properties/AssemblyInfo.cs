using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#if __IOS__
using Foundation;
#endif

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

#if __IOS__
// This attribute allows you to mark your assemblies as “safe to link”. 
// When the attribute is present, the linker—if enabled—will process the assembly 
// even if you’re using the “Link SDK assemblies only” option, which is the default for device builds.
[assembly: LinkerSafe]
#endif

