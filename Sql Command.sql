GO
USE [CSK23T3A]
GO
ALTER TABLE PRODUCTS
ADD CONSTRAINT FK_PRODUCTS_CATEGORYID
FOREIGN KEY(CATEGORYID)
REFERENCES CATEGORIES(CATEGORYID)

ALTER TABLE PRODUCTS
ADD CONSTRAINT FK_PRODUCTS_SIZEID
FOREIGN KEY(SIZEID)
REFERENCES PRODUCTSIZES(SIZEID)

ALTER TABLE ORDERDETAILS
ADD CONSTRAINT FK_ORDERDETAILS_PRODUCTID
FOREIGN KEY(PRODUCTID)
REFERENCES PRODUCTS(ID)

ALTER TABLE ORDERDETAILS
ADD CONSTRAINT FK_ORDERDETAILS_ORDERID
FOREIGN KEY(ORDERID)
REFERENCES ORDERS(ID)

ALTER TABLE CONTACTDETAILS
ADD CONSTRAINT FK_CONTACTDETAILS_CONTACTID
FOREIGN KEY(CONTACTID)
REFERENCES CONTACTS(CONTACTID)