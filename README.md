QR_Code
=======


1. introduction
=======
QRcode is two dimensional code which is categorized in matrix codeSample image of QRcode is below.
 
Features of QRcode are 
•	High-speed reading(QR is derived from "Quick Response") 
•	High capacity and high density 
•	Error correcting 
•	Structured Append 

1.1 Model of QRcode 
=======
QRcode model1:Original model.
QRcode model2:Extended model.

1.2 Characters which can be encoded in QRcode.(encode mode) 
=======
•	numeric(0-9)
3 characters are encoded to 10bit length.
In theory, 7089 characters or less can be stored in a QRcode. 
•	alphanumeric(0-9A-Z $%*+-./:)45characters
2 characters are encoded to 11bit length.
In theory, 4296 characters or less can be stored in a QRcode. 
•	8bit byte data
In theory, 2953 characters or less can be stored in a QRcode.
•	KANJI
A KANJI character(this is multi byte character) is encoded to 13bit length.
In theory, 1817 characters or less can be stored in a QRcode.

1.3 Error correcting in QRcode. 
=======
QRcode has a function of an error correcting for miss reading that white is black.
Error correcting is defined in 4 level as below.
•	level L : About 7% or less errors can be corrected. 
•	level M : About 15% or less errors can be corrected. 
•	level Q : About 25% or less errors can be corrected. 
•	level H : About 30% or less errors can be corrected. 
1.4 Version in QRcode. 
=======
Size of QRcode is defined as version.
Version is from 1 to 40.
Version 1 is 21*21 matrix. And 4 modules increases whenever 1 version increases. So version 40 is 177*177 matrix.
1.5 Structure of QRcode symbol. 
=======
The below figure is a structure of QRcode model2 version 1. In the below figure,white or black parts are fixed in specification. They are "finder pattern" and "timing pattern"."Finder pattern" is used to help detection a position of QRcode in decoder application."Timing pattern" is used to help determine a symbol's coordinate in decoder application.

In yellow color parts,encoded data (including error correct code) are stored.And in cyan color parts,information of error correcting level and mask pattern(described later) are stored.This is called format information

 

■encoded data (including error correct code)
■format information

In addition, version2 or higher has "alignment pattern" which is used to correct skewness in decoder application.
And version 7 or higher has "version information" which has information of version itself.


