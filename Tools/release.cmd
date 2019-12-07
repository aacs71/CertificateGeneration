C:\Windows\Microsoft.NET\Framework64\v4.0.30319\msbuild /p:Configuration=Release ..\Src\CertificateManager.sln
Mkdir ..\Build
..\Tools\ILMerge.exe /ndebug /copyattrs /out:"..\Build\CertificateGenerator.exe" ..\Src\CertificateManager\bin\Release\CertificateManager.exe ..\Src\CertificateManager\bin\Release\BouncyCastle.Crypto.dll