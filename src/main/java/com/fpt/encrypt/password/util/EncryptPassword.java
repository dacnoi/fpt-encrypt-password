package com.fpt.encrypt.password.util;

import java.io.File;
import java.io.IOException;

import org.springframework.util.ResourceUtils;

import fptframework.outhouse.security.LibEncryption;
import net.sf.jni4net.Bridge;

public class EncryptPassword {

	public static String encryptPassword(String password) {
		if (password == null || password.isEmpty())
			return null;
		String passwordEncrypt = "";
		Bridge.setVerbose(true);
		try {
			Bridge.init();
			File dllFile = ResourceUtils.getFile("classpath:FptFramework.OutHouse.Security.j4n.dll"); 
//			File dllFile =  new File("src/main/resources/FptFramework.OutHouse.Security.j4n.dll");
			Bridge.LoadAndRegisterAssemblyFrom(dllFile);
			Bridge.LoadAndRegisterAssemblyFrom(ResourceUtils.getFile("classpath:FptFramework.OutHouse.Security.dll"));
			passwordEncrypt = LibEncryption.Encrypt_Password(password);
			return passwordEncrypt;
		} catch (IOException e) {
			e.printStackTrace();
		}
		return passwordEncrypt;
	}

	public static void main(String[] args) {
		System.out.println(encryptPassword("1q2w3e4r"));
	}
}
