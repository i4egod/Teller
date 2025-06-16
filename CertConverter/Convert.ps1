docker build -q -t cert-converter .
docker run --rm -v "${pwd}/Certificates:/Certificates" cert-converter
ls ./Certificates
pause