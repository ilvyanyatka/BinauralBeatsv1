cd "C:\Users\Victoria\source\repos\BinauralBeatsv1"
IF EXIST "bin\Debug\beats" GOTO DONT_CREATE_DIR
  md "bin\Debug\beats"
  copy "beats" "bin\Debug\beats"
:DONT_CREATE_DIR