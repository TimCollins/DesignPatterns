namespace BlackWasp.AbstractFactory
{
    public class ExampleClient
    {
        private readonly Packaging _packaging;
        private readonly DeliveryDocument _deliveryDocument;

        public ExampleClient(PurchaseFactory factory)
        {
            _packaging = factory.CreatePackaging();
            _deliveryDocument = factory.CreateDeliveryDocument();
        }

        public Packaging ClientPackaging
        {
            get { return _packaging; }
        }

        public DeliveryDocument ClientDocument
        {
            get { return _deliveryDocument; }
        }
    }

    public abstract class PurchaseFactory
    {
        internal abstract Packaging CreatePackaging();
        internal abstract DeliveryDocument CreateDeliveryDocument();
    }

    public class StandardPurchaseFactory : PurchaseFactory
    {
        internal override Packaging CreatePackaging()
        {
            return new StandardPackaging();
        }

        internal override DeliveryDocument CreateDeliveryDocument()
        {
            return new PostalLabel();
        }
    }

    public class DelicatePurchaseFactory : PurchaseFactory
    {
        internal override Packaging CreatePackaging()
        {
            return new ShockProofPackaging();
        }

        internal override DeliveryDocument CreateDeliveryDocument()
        {
            return new CourierManifest();
        }
    }

    public abstract class Packaging { }
    internal class StandardPackaging : Packaging { }
    internal class ShockProofPackaging : Packaging { }

    public abstract class DeliveryDocument { }
    internal class PostalLabel : DeliveryDocument { }
    internal class CourierManifest : DeliveryDocument { }
}
