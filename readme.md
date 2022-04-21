PDFView4NET is a .NET toolkit for adding PDF render, view and print support in .NET applications. It includes a PDF viewer control for Windows Forms and WPF and a .NET library for rendering and printing PDF files from any .NET application. The PDF viewer control includes support for annotating PDF files, bookmarks navigation, adding and removing file attachments and other features. The toolkit includes its own PDF rendering engine and it does not rely on any other software for rendering and printing PDF files. PDFView4NET toolkit has been developed entirely in C#, being 100% managed code.  
The toolkit comes in 2 separate editions, Windows Forms and WPF.  
**NOTE:**  There might be PDF files will not be displayed or printed correctly. Feel free to  [send us](mailto:techsupport@o2sol.com)  any PDF file that is not handled correctly and we'll work on it.  
  
**The main features of PDFView4NET library are outlined below:**  

### PDF Rendering
**General**
- Support for .NET Framework 4.x, .NET Core 3.x and .NET 5 / 6
- Load documents from file and stream
- Support for encrypted files, both RC4 40/128bit and AES 128/256bit are supported
- Render PDF files to Bmp, Gif, Jpeg or Tiff
- Render PDF files to multipage B/W Tiff with dithering and CCITT Fax compression
- Render PDF files to System.Drawing.Graphics
- Render PDF page content according to layer visibility

**Filters and compression**
- FlateDecode
- LZWDecode
- ASCII85Decode
- ASCIIHexDecode
- CCITTFaxDecode
- DCTDecode
- JPXDecode
- JBIG2Decode

**Images**
- RAW, DCT/JPEG, CCITT, JPEG2000, JBIG2
- Inline images
- Soft masks, image masks and chroma key masks

**Fonts**
- Standard PDF fonts
- Embedded fonts
- CID-keyed fonts
- TrueType
- Type 1 (CFF and Postscript)
- Type 3

**Colorspaces**
- Device colorspaces: RGB, CMYK and Gray
- Calibrated colorspaces: CalRGB, CalGray, Lab and ICC
- Separation
- DeviceN
- Indexed

**Printing**
- Print PDF files to any printer
- Print page content and/or annotations and/or form fields
- Auto-rotate and center
- Print custom page range
- Multiple print scaling options
- Print multiples pages per sheet (2-up, 4-up, n-up)
- Print custom content under and on top of printed PDF page

### PDF View controls
**General**
- All PDF rendering features
- Support for .NET Framework 4.x, .NET Core 3.x and .NET 5 Windows Forms
- Support for .NET Framework 4.x, .NET Core 3.x and .NET 5 WPF
- Load documents from file and stream
- Support for encrypted files (load and save), both RC4 40/128bit and AES 128/256bit are supported

**Navigation**
- Zoom (absolute, fit width, fit height, fit visible, zoom in, zoom out, dynamic zoom, marquee zoom)
- Pan
- Rotate pages
- PDFBookmarksView control for displaying bookmarks and navigating within the document
- Single page, one column and two columns page display layouts

**Annotations**
- Display all annotations
- Add/Edit text, free text, ellipse, file attachment, ink, line, rectangle, stamp, link, highlight, underline, strikeout and barcode annotations
- Create text and stamp annotations with custom appearance
- Annotation popup windows
- Delete any annotation
- PDFAnnotationsView control for displaying all the annotations in a document (similar to Adobe Acrobat)
- Standard and owner draw annotation tooltips

**PDF forms**
- User interactive form design
- Add, edit and remove form fields
- User interactive form filling
- Create and fill forms from code
- Pushbutton, checkbox, radiobutton, dropdown list and listbox fields
- Highlight form fields on the page
- Field tooltips
- Save filled forms

**Text**
- Extract page text
- Search text and highlight search results
- Text selection and copy

**Document attachments**
- Add/Edit/Delete file attachments
