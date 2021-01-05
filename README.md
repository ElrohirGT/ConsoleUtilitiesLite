# ConsoleUtilitiesLite
A simple collection of functions that I use in the console.

#Documentation
<a name='assembly'></a>
## Contents

- [ConsoleUtilitiesLite](#T-ConsoleUtilitiesLite-ConsoleUtilitiesLite 'ConsoleUtilitiesLite.ConsoleUtilitiesLite')
  - [DivisionColor](#P-ConsoleUtilitiesLite-ConsoleUtilitiesLite-DivisionColor 'ConsoleUtilitiesLite.ConsoleUtilitiesLite.DivisionColor')
  - [DivisionSign](#P-ConsoleUtilitiesLite-ConsoleUtilitiesLite-DivisionSign 'ConsoleUtilitiesLite.ConsoleUtilitiesLite.DivisionSign')
  - [ErrorMessageColor](#P-ConsoleUtilitiesLite-ConsoleUtilitiesLite-ErrorMessageColor 'ConsoleUtilitiesLite.ConsoleUtilitiesLite.ErrorMessageColor')
  - [InfoMessageColor](#P-ConsoleUtilitiesLite-ConsoleUtilitiesLite-InfoMessageColor 'ConsoleUtilitiesLite.ConsoleUtilitiesLite.InfoMessageColor')
  - [SubDivisionColor](#P-ConsoleUtilitiesLite-ConsoleUtilitiesLite-SubDivisionColor 'ConsoleUtilitiesLite.ConsoleUtilitiesLite.SubDivisionColor')
  - [SubDivisionSign](#P-ConsoleUtilitiesLite-ConsoleUtilitiesLite-SubDivisionSign 'ConsoleUtilitiesLite.ConsoleUtilitiesLite.SubDivisionSign')
  - [SuccessMessageColor](#P-ConsoleUtilitiesLite-ConsoleUtilitiesLite-SuccessMessageColor 'ConsoleUtilitiesLite.ConsoleUtilitiesLite.SuccessMessageColor')
  - [TitleColor](#P-ConsoleUtilitiesLite-ConsoleUtilitiesLite-TitleColor 'ConsoleUtilitiesLite.ConsoleUtilitiesLite.TitleColor')
  - [WarningMessageColor](#P-ConsoleUtilitiesLite-ConsoleUtilitiesLite-WarningMessageColor 'ConsoleUtilitiesLite.ConsoleUtilitiesLite.WarningMessageColor')
  - [CenterLine(text)](#M-ConsoleUtilitiesLite-ConsoleUtilitiesLite-CenterLine-System-String- 'ConsoleUtilitiesLite.ConsoleUtilitiesLite.CenterLine(System.String)')
  - [ClearPreviousLog(length)](#M-ConsoleUtilitiesLite-ConsoleUtilitiesLite-ClearPreviousLog-System-Int32- 'ConsoleUtilitiesLite.ConsoleUtilitiesLite.ClearPreviousLog(System.Int32)')
  - [Division()](#M-ConsoleUtilitiesLite-ConsoleUtilitiesLite-Division 'ConsoleUtilitiesLite.ConsoleUtilitiesLite.Division')
  - [Division(length)](#M-ConsoleUtilitiesLite-ConsoleUtilitiesLite-Division-System-Int32- 'ConsoleUtilitiesLite.ConsoleUtilitiesLite.Division(System.Int32)')
  - [LogErrorMessage(message,args)](#M-ConsoleUtilitiesLite-ConsoleUtilitiesLite-LogErrorMessage-System-String,System-String[]- 'ConsoleUtilitiesLite.ConsoleUtilitiesLite.LogErrorMessage(System.String,System.String[])')
  - [LogFormat(format,foregroundColor,args)](#M-ConsoleUtilitiesLite-ConsoleUtilitiesLite-LogFormat-System-String,System-ConsoleColor,System-String[]- 'ConsoleUtilitiesLite.ConsoleUtilitiesLite.LogFormat(System.String,System.ConsoleColor,System.String[])')
  - [LogImage(imagePath,newPath)](#M-ConsoleUtilitiesLite-ConsoleUtilitiesLite-LogImage-System-String,System-String- 'ConsoleUtilitiesLite.ConsoleUtilitiesLite.LogImage(System.String,System.String)')
  - [LogInfoMessage(message,args)](#M-ConsoleUtilitiesLite-ConsoleUtilitiesLite-LogInfoMessage-System-String,System-String[]- 'ConsoleUtilitiesLite.ConsoleUtilitiesLite.LogInfoMessage(System.String,System.String[])')
  - [LogSuccessMessage(message,args)](#M-ConsoleUtilitiesLite-ConsoleUtilitiesLite-LogSuccessMessage-System-String,System-String[]- 'ConsoleUtilitiesLite.ConsoleUtilitiesLite.LogSuccessMessage(System.String,System.String[])')
  - [LogWarningMessage(message,args)](#M-ConsoleUtilitiesLite-ConsoleUtilitiesLite-LogWarningMessage-System-String,System-String[]- 'ConsoleUtilitiesLite.ConsoleUtilitiesLite.LogWarningMessage(System.String,System.String[])')
  - [ShowTitle(title)](#M-ConsoleUtilitiesLite-ConsoleUtilitiesLite-ShowTitle-System-String[]- 'ConsoleUtilitiesLite.ConsoleUtilitiesLite.ShowTitle(System.String[])')
  - [ShowVersion(version)](#M-ConsoleUtilitiesLite-ConsoleUtilitiesLite-ShowVersion-System-String- 'ConsoleUtilitiesLite.ConsoleUtilitiesLite.ShowVersion(System.String)')
  - [SubDivision()](#M-ConsoleUtilitiesLite-ConsoleUtilitiesLite-SubDivision 'ConsoleUtilitiesLite.ConsoleUtilitiesLite.SubDivision')
  - [SubDivision(length)](#M-ConsoleUtilitiesLite-ConsoleUtilitiesLite-SubDivision-System-Int32- 'ConsoleUtilitiesLite.ConsoleUtilitiesLite.SubDivision(System.Int32)')

<a name='T-ConsoleUtilitiesLite-ConsoleUtilitiesLite'></a>
## ConsoleUtilitiesLite `type`

##### Namespace

ConsoleUtilitiesLite

##### Summary

Some simple console utilities I use on my projects.

<a name='P-ConsoleUtilitiesLite-ConsoleUtilitiesLite-DivisionColor'></a>
### DivisionColor `property`

##### Summary

Color used to make divisions on the console.

##### See Also

- [ConsoleUtilitiesLite.ConsoleUtilitiesLite.Division](#M-ConsoleUtilitiesLite-ConsoleUtilitiesLite-Division 'ConsoleUtilitiesLite.ConsoleUtilitiesLite.Division')
- [ConsoleUtilitiesLite.ConsoleUtilitiesLite.Division](#M-ConsoleUtilitiesLite-ConsoleUtilitiesLite-Division-System-Int32- 'ConsoleUtilitiesLite.ConsoleUtilitiesLite.Division(System.Int32)')

<a name='P-ConsoleUtilitiesLite-ConsoleUtilitiesLite-DivisionSign'></a>
### DivisionSign `property`

##### Summary

Char used to make the divisions on the console.

##### See Also

- [ConsoleUtilitiesLite.ConsoleUtilitiesLite.Division](#M-ConsoleUtilitiesLite-ConsoleUtilitiesLite-Division 'ConsoleUtilitiesLite.ConsoleUtilitiesLite.Division')
- [ConsoleUtilitiesLite.ConsoleUtilitiesLite.Division](#M-ConsoleUtilitiesLite-ConsoleUtilitiesLite-Division-System-Int32- 'ConsoleUtilitiesLite.ConsoleUtilitiesLite.Division(System.Int32)')

<a name='P-ConsoleUtilitiesLite-ConsoleUtilitiesLite-ErrorMessageColor'></a>
### ErrorMessageColor `property`

##### Summary

Text color used in the `ErrorMessage` method.

##### See Also

- [ConsoleUtilitiesLite.ConsoleUtilitiesLite.LogErrorMessage](#M-ConsoleUtilitiesLite-ConsoleUtilitiesLite-LogErrorMessage-System-String,System-String[]- 'ConsoleUtilitiesLite.ConsoleUtilitiesLite.LogErrorMessage(System.String,System.String[])')

<a name='P-ConsoleUtilitiesLite-ConsoleUtilitiesLite-InfoMessageColor'></a>
### InfoMessageColor `property`

##### Summary

Text color used in the `InfoMessage` method.

##### See Also

- [ConsoleUtilitiesLite.ConsoleUtilitiesLite.LogInfoMessage](#M-ConsoleUtilitiesLite-ConsoleUtilitiesLite-LogInfoMessage-System-String,System-String[]- 'ConsoleUtilitiesLite.ConsoleUtilitiesLite.LogInfoMessage(System.String,System.String[])')

<a name='P-ConsoleUtilitiesLite-ConsoleUtilitiesLite-SubDivisionColor'></a>
### SubDivisionColor `property`

##### Summary

Color used to make sub divisions on the console.

##### See Also

- [ConsoleUtilitiesLite.ConsoleUtilitiesLite.SubDivision](#M-ConsoleUtilitiesLite-ConsoleUtilitiesLite-SubDivision 'ConsoleUtilitiesLite.ConsoleUtilitiesLite.SubDivision')
- [ConsoleUtilitiesLite.ConsoleUtilitiesLite.SubDivision](#M-ConsoleUtilitiesLite-ConsoleUtilitiesLite-SubDivision-System-Int32- 'ConsoleUtilitiesLite.ConsoleUtilitiesLite.SubDivision(System.Int32)')

<a name='P-ConsoleUtilitiesLite-ConsoleUtilitiesLite-SubDivisionSign'></a>
### SubDivisionSign `property`

##### Summary

Char used to make the sub divisions on the console.

##### See Also

- [ConsoleUtilitiesLite.ConsoleUtilitiesLite.SubDivision](#M-ConsoleUtilitiesLite-ConsoleUtilitiesLite-SubDivision 'ConsoleUtilitiesLite.ConsoleUtilitiesLite.SubDivision')
- [ConsoleUtilitiesLite.ConsoleUtilitiesLite.SubDivision](#M-ConsoleUtilitiesLite-ConsoleUtilitiesLite-SubDivision-System-Int32- 'ConsoleUtilitiesLite.ConsoleUtilitiesLite.SubDivision(System.Int32)')

<a name='P-ConsoleUtilitiesLite-ConsoleUtilitiesLite-SuccessMessageColor'></a>
### SuccessMessageColor `property`

##### Summary

Text color used in the `SuccessMessage` method.

##### See Also

- [ConsoleUtilitiesLite.ConsoleUtilitiesLite.LogSuccessMessage](#M-ConsoleUtilitiesLite-ConsoleUtilitiesLite-LogSuccessMessage-System-String,System-String[]- 'ConsoleUtilitiesLite.ConsoleUtilitiesLite.LogSuccessMessage(System.String,System.String[])')

<a name='P-ConsoleUtilitiesLite-ConsoleUtilitiesLite-TitleColor'></a>
### TitleColor `property`

##### Summary

Text color used in the `ShowTitle` method.

##### See Also

- [ConsoleUtilitiesLite.ConsoleUtilitiesLite.ShowTitle](#M-ConsoleUtilitiesLite-ConsoleUtilitiesLite-ShowTitle-System-String[]- 'ConsoleUtilitiesLite.ConsoleUtilitiesLite.ShowTitle(System.String[])')

<a name='P-ConsoleUtilitiesLite-ConsoleUtilitiesLite-WarningMessageColor'></a>
### WarningMessageColor `property`

##### Summary

Text color used in the `WarningMessage` method.

##### See Also

- [ConsoleUtilitiesLite.ConsoleUtilitiesLite.LogWarningMessage](#M-ConsoleUtilitiesLite-ConsoleUtilitiesLite-LogWarningMessage-System-String,System-String[]- 'ConsoleUtilitiesLite.ConsoleUtilitiesLite.LogWarningMessage(System.String,System.String[])')

<a name='M-ConsoleUtilitiesLite-ConsoleUtilitiesLite-CenterLine-System-String-'></a>
### CenterLine(text) `method`

##### Summary

Returns the `text` given with the right amount of spaces to be centered on the screen.

##### Returns

The text with the right amount of spaces.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| text | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The text to be centered. |

<a name='M-ConsoleUtilitiesLite-ConsoleUtilitiesLite-ClearPreviousLog-System-Int32-'></a>
### ClearPreviousLog(length) `method`

##### Summary

Deletes the previous log.
Nothing should be outputted to the console between the call of a log and this function for this function to work properly.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| length | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The size of the previous logged string |

<a name='M-ConsoleUtilitiesLite-ConsoleUtilitiesLite-Division'></a>
### Division() `method`

##### Summary

Creates a division with a length equal to the `Console.BufferWidth`,
uses the `DivisionSign` property to make the division.

##### Parameters

This method has no parameters.

##### See Also

- [ConsoleUtilitiesLite.ConsoleUtilitiesLite.DivisionSign](#P-ConsoleUtilitiesLite-ConsoleUtilitiesLite-DivisionSign 'ConsoleUtilitiesLite.ConsoleUtilitiesLite.DivisionSign')

<a name='M-ConsoleUtilitiesLite-ConsoleUtilitiesLite-Division-System-Int32-'></a>
### Division(length) `method`

##### Summary

Creates a Cyan division with the specified `length`,
uses the `DivisionSign` property to make the division.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| length | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The length of the division to create. |

##### See Also

- [ConsoleUtilitiesLite.ConsoleUtilitiesLite.DivisionSign](#P-ConsoleUtilitiesLite-ConsoleUtilitiesLite-DivisionSign 'ConsoleUtilitiesLite.ConsoleUtilitiesLite.DivisionSign')

<a name='M-ConsoleUtilitiesLite-ConsoleUtilitiesLite-LogErrorMessage-System-String,System-String[]-'></a>
### LogErrorMessage(message,args) `method`

##### Summary

Shows the specified `message`,
With the color of `ErrorMessageColor`,
`args` is passed as is to the `Console.WriteLine` method.

##### Returns

The length of the string that was logged, useful for using `ClearPreviousLog`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The message to write to the console. |
| args | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') | An array of objects to write using. |

<a name='M-ConsoleUtilitiesLite-ConsoleUtilitiesLite-LogFormat-System-String,System-ConsoleColor,System-String[]-'></a>
### LogFormat(format,foregroundColor,args) `method`

##### Summary

Logs the message with the specified arguments.

##### Returns

The length of the string that was logged, useful for using `ClearPreviousLog`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| format | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| foregroundColor | [System.ConsoleColor](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ConsoleColor 'System.ConsoleColor') |  |
| args | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') |  |

<a name='M-ConsoleUtilitiesLite-ConsoleUtilitiesLite-LogImage-System-String,System-String-'></a>
### LogImage(imagePath,newPath) `method`

##### Summary

Logs a message that shows that the `imagePath` is being copied to `newPath`,
the color used is from `LogImageColor`.

##### Returns

The length of the string that was logged, useful for using `ClearPreviousLog`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| imagePath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The path of the image that is being copied. |
| newPath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The new path that the image will be copied to. |

<a name='M-ConsoleUtilitiesLite-ConsoleUtilitiesLite-LogInfoMessage-System-String,System-String[]-'></a>
### LogInfoMessage(message,args) `method`

##### Summary

Shows the specified `message`,
With the color of `InfoMessageColor`,
`args` is passed as is to the `Console.WriteLine` method.

##### Returns

The length of the string that was logged, useful for using `ClearPreviousLog`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The message to write to the console. |
| args | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') | An array of objects to write using. |

<a name='M-ConsoleUtilitiesLite-ConsoleUtilitiesLite-LogSuccessMessage-System-String,System-String[]-'></a>
### LogSuccessMessage(message,args) `method`

##### Summary

Shows the specified `message`,
With the color of `SuccessMessageColor`,
`args` is passed as is to the `Console.WriteLine` method.

##### Returns

The length of the string that was logged, useful for using `ClearPreviousLog`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The message to write to the console. |
| args | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') | An array of objects to write using. |

<a name='M-ConsoleUtilitiesLite-ConsoleUtilitiesLite-LogWarningMessage-System-String,System-String[]-'></a>
### LogWarningMessage(message,args) `method`

##### Summary

Shows the specified `message`,
With the color of `WarningMessageColor`,
`args` is passed as is to the `Console.WriteLine` method.

##### Returns

The length of the string that was logged, useful for using `ClearPreviousLog`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The message to write to the console. |
| args | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') | An array of objects to write using. |

<a name='M-ConsoleUtilitiesLite-ConsoleUtilitiesLite-ShowTitle-System-String[]-'></a>
### ShowTitle(title) `method`

##### Summary

Shows each line of the given array to the console,
uses the color of `TitleColor`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| title | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') | The title to be showed. |

##### See Also

- [ConsoleUtilitiesLite.ConsoleUtilitiesLite.TitleColor](#P-ConsoleUtilitiesLite-ConsoleUtilitiesLite-TitleColor 'ConsoleUtilitiesLite.ConsoleUtilitiesLite.TitleColor')

<a name='M-ConsoleUtilitiesLite-ConsoleUtilitiesLite-ShowVersion-System-String-'></a>
### ShowVersion(version) `method`

##### Summary

Logs a Runnning Version message with the color of warning. You can get the version of the assembly by calling:
`System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString());`

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| version | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The version of the assembly. |

<a name='M-ConsoleUtilitiesLite-ConsoleUtilitiesLite-SubDivision'></a>
### SubDivision() `method`

##### Summary

Creates a sub-division with a length equal to the `Console.BufferWidth`
Uses the `SubDivisionSign` property to make the division.

##### Parameters

This method has no parameters.

##### See Also

- [ConsoleUtilitiesLite.ConsoleUtilitiesLite.DivisionSign](#P-ConsoleUtilitiesLite-ConsoleUtilitiesLite-DivisionSign 'ConsoleUtilitiesLite.ConsoleUtilitiesLite.DivisionSign')

<a name='M-ConsoleUtilitiesLite-ConsoleUtilitiesLite-SubDivision-System-Int32-'></a>
### SubDivision(length) `method`

##### Summary

Creates a sub-division with the specified `length`,
uses the `SubDivisionSign` property to make the division.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| length | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The length of the division to create. |

##### See Also

- [ConsoleUtilitiesLite.ConsoleUtilitiesLite.DivisionSign](#P-ConsoleUtilitiesLite-ConsoleUtilitiesLite-DivisionSign 'ConsoleUtilitiesLite.ConsoleUtilitiesLite.DivisionSign')

