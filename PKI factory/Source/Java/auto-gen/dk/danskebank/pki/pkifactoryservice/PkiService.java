package dk.danskebank.pki.pkifactoryservice;

import java.net.URL;
import javax.xml.namespace.QName;
import javax.xml.ws.WebEndpoint;
import javax.xml.ws.WebServiceClient;
import javax.xml.ws.WebServiceFeature;
import javax.xml.ws.Service;

/**
 * This class was generated by Apache CXF 3.1.4
 * 2016-01-28T15:18:54.813+01:00
 * Generated source version: 3.1.4
 * 
 */
@WebServiceClient(name = "PkiService", 
                  wsdlLocation = "PKIService.wsdl",
                  targetNamespace = "http://danskebank.dk/PKI/PKIFactoryService") 
public class PkiService extends Service {

    public final static URL WSDL_LOCATION;

    public final static QName SERVICE = new QName("http://danskebank.dk/PKI/PKIFactoryService", "PkiService");
    public final static QName PkiServiceHttpPort = new QName("http://danskebank.dk/PKI/PKIFactoryService", "PkiServiceHttpPort");
    static {
        URL url = PkiService.class.getResource("PKIService.wsdl");
        if (url == null) {
            url = PkiService.class.getClassLoader().getResource("PKIService.wsdl");
        } 
        if (url == null) {
            java.util.logging.Logger.getLogger(PkiService.class.getName())
                .log(java.util.logging.Level.INFO, 
                     "Can not initialize the default wsdl from {0}", "PKIService.wsdl");
        }       
        WSDL_LOCATION = url;
    }

    public PkiService(URL wsdlLocation) {
        super(wsdlLocation, SERVICE);
    }

    public PkiService(URL wsdlLocation, QName serviceName) {
        super(wsdlLocation, serviceName);
    }

    public PkiService() {
        super(WSDL_LOCATION, SERVICE);
    }
    
    public PkiService(WebServiceFeature ... features) {
        super(WSDL_LOCATION, SERVICE, features);
    }

    public PkiService(URL wsdlLocation, WebServiceFeature ... features) {
        super(wsdlLocation, SERVICE, features);
    }

    public PkiService(URL wsdlLocation, QName serviceName, WebServiceFeature ... features) {
        super(wsdlLocation, serviceName, features);
    }    




    /**
     *
     * @return
     *     returns PkiServicePortType
     */
    @WebEndpoint(name = "PkiServiceHttpPort")
    public PkiServicePortType getPkiServiceHttpPort() {
        return super.getPort(PkiServiceHttpPort, PkiServicePortType.class);
    }

    /**
     * 
     * @param features
     *     A list of {@link javax.xml.ws.WebServiceFeature} to configure on the proxy.  Supported features not in the <code>features</code> parameter will have their default values.
     * @return
     *     returns PkiServicePortType
     */
    @WebEndpoint(name = "PkiServiceHttpPort")
    public PkiServicePortType getPkiServiceHttpPort(WebServiceFeature... features) {
        return super.getPort(PkiServiceHttpPort, PkiServicePortType.class, features);
    }

}
