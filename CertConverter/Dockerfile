FROM alpine:latest

RUN apk add --no-cache openssl

WORKDIR /Certificates

COPY Certificates/ .

CMD ["sh", "-c", "openssl pkcs12 -export -out certificate.pfx -inkey private_key.pem -in certificate.pem -passout pass:"]