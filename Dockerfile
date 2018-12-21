FROM openjdk:8-jdk
MAINTAINER noipd <noipd@fpt.com.vn>
ADD target/fpt-encrypt-password-0.0.1.jar fpt-encrypt-password-0.0.1.jar
ENTRYPOINT ["java", "-Djava.security.egd=file:/dev/./urandom","-jar", "/fpt-encrypt-password-0.0.1.jar"]
EXPOSE 2222