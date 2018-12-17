using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Pkcs;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.X509;
using System;
using System.Security.Cryptography;
using System.Text;
using System.Xml;

namespace LichKin.Utils.Security
{
    /// <summary>
    ///     RSA工具类
    /// </summary>
    public class RSAUtils
    {
        /// <summary>
        ///     生成秘钥
        /// </summary>
        /// <param name="primaryKey">私钥</param>
        /// <param name="publicKey">公钥</param>
        /// <returns>
        ///     加密后的字符串
        /// </returns>
        public static void Create(out String primaryKey, out String publicKey)
        {
            try
            {
                RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
                primaryKey = rsa.ToXmlString(true);
                publicKey = rsa.ToXmlString(false);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        ///     加密
        /// </summary>
        /// <param name="publicKey">公钥</param>
        /// <param name="str">待加密的字符串</param>
        /// <returns>
        ///     加密后的字符串
        /// </returns>
        public static String Encrypt(String publicKey, String str)
        {
            try
            {
                RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
                rsa.FromXmlString(publicKey);
                return Convert.ToBase64String(rsa.Encrypt(Encoding.UTF8.GetBytes(str), false));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        ///     解密
        /// </summary>
        /// <param name="primaryKey">私钥</param>
        /// <param name="str">待解密的字符串</param>
        /// <returns>
        ///     解密后的字符串
        /// </returns>
        public static String Decrypt(string primaryKey, string str)
        {
            try
            {
                RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
                rsa.FromXmlString(primaryKey);
                return Encoding.UTF8.GetString(rsa.Decrypt(Convert.FromBase64String(str), false));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        ///     将XML格式秘钥转为PEM格式秘钥
        /// </summary>
        /// <param name="primary">true:私钥;false:公钥;</param>
        /// <param name="xmlKey">XML格式秘钥</param>
        /// <returns>
        ///     PEM格式秘钥
        /// </returns>
        public static String XML2PEM(Boolean primary, String xmlKey)
        {
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xmlKey);

            XmlElement xmlElement = doc.DocumentElement;
            BigInteger Modulus = new BigInteger(1, Convert.FromBase64String(xmlElement.GetElementsByTagName("Modulus")[0].InnerText));
            BigInteger Exponent = new BigInteger(1, Convert.FromBase64String(xmlElement.GetElementsByTagName("Exponent")[0].InnerText));

            byte[] bytes;
            if (primary)
            {
                BigInteger D = new BigInteger(1, Convert.FromBase64String(xmlElement.GetElementsByTagName("D")[0].InnerText));
                BigInteger P = new BigInteger(1, Convert.FromBase64String(xmlElement.GetElementsByTagName("P")[0].InnerText));
                BigInteger Q = new BigInteger(1, Convert.FromBase64String(xmlElement.GetElementsByTagName("Q")[0].InnerText));
                BigInteger DP = new BigInteger(1, Convert.FromBase64String(xmlElement.GetElementsByTagName("DP")[0].InnerText));
                BigInteger DQ = new BigInteger(1, Convert.FromBase64String(xmlElement.GetElementsByTagName("DQ")[0].InnerText));
                BigInteger InverseQ = new BigInteger(1, Convert.FromBase64String(xmlElement.GetElementsByTagName("InverseQ")[0].InnerText));

                bytes = PrivateKeyInfoFactory.CreatePrivateKeyInfo(new RsaPrivateCrtKeyParameters(Modulus, Exponent, D, P, Q, DP, DQ, InverseQ)).ToAsn1Object().GetEncoded();
            }
            else
            {
                bytes = SubjectPublicKeyInfoFactory.CreateSubjectPublicKeyInfo(new RsaKeyParameters(false, Modulus, Exponent)).ToAsn1Object().GetDerEncoded();
            }
            return Convert.ToBase64String(bytes);
        }

        /// <summary>
        ///     将PEM格式秘钥转为XML格式秘钥
        /// </summary>
        /// <param name="primary">true:私钥;false:公钥;</param>
        /// <param name="pemKey">PEM格式秘钥</param>
        /// <returns>
        ///     XML格式秘钥
        /// </returns>
        public static String PEM2XML(Boolean primary, String pemKey)
        {
            if (primary)
            {
                RsaPrivateCrtKeyParameters privateKeyParam = (RsaPrivateCrtKeyParameters)PrivateKeyFactory.CreateKey(Convert.FromBase64String(pemKey));
                return String.Format
                (
                    "<RSAKeyValue><Modulus>{0}</Modulus><Exponent>{1}</Exponent><P>{2}</P><Q>{3}</Q><DP>{4}</DP><DQ>{5}</DQ><InverseQ>{6}</InverseQ><D>{7}</D></RSAKeyValue>",
                    Convert.ToBase64String(privateKeyParam.Modulus.ToByteArrayUnsigned()),
                    Convert.ToBase64String(privateKeyParam.PublicExponent.ToByteArrayUnsigned()),
                    Convert.ToBase64String(privateKeyParam.P.ToByteArrayUnsigned()),
                    Convert.ToBase64String(privateKeyParam.Q.ToByteArrayUnsigned()),
                    Convert.ToBase64String(privateKeyParam.DP.ToByteArrayUnsigned()),
                    Convert.ToBase64String(privateKeyParam.DQ.ToByteArrayUnsigned()),
                    Convert.ToBase64String(privateKeyParam.QInv.ToByteArrayUnsigned()),
                    Convert.ToBase64String(privateKeyParam.Exponent.ToByteArrayUnsigned())
                );
            }
            else
            {
                RsaKeyParameters publicKeyParam = (RsaKeyParameters)PublicKeyFactory.CreateKey(Convert.FromBase64String(pemKey));
                return String.Format
                (
                    "<RSAKeyValue><Modulus>{0}</Modulus><Exponent>{1}</Exponent></RSAKeyValue>",
                    Convert.ToBase64String(publicKeyParam.Modulus.ToByteArrayUnsigned()),
                    Convert.ToBase64String(publicKeyParam.Exponent.ToByteArrayUnsigned())
                );
            }
        }
    }
}
