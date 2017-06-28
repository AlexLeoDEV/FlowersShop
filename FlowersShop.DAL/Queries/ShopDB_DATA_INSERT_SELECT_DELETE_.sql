

INSERT INTO Category ( Title) VALUES ('Flower composition'); --1
INSERT INTO Category ( Title) VALUES ('Mono bouquet');       --2
INSERT INTO Category ( Title) VALUES ('Bouquet');			 --3
INSERT INTO Category ( Title) VALUES ('Flower basket');		 --4
INSERT INTO Category ( Title) VALUES ('Flower');			 --5
INSERT INTO Category ( Title) VALUES ('Grass');				 --6
INSERT INTO Category ( Title) VALUES ('Decoration');		 --7

SELECT * FROM Category


INSERT INTO Preferences (ForWhom) VALUES ('Mom');
INSERT INTO Preferences (ForWhom) VALUES ('Beloved');
INSERT INTO Preferences (ForWhom) VALUES ('Colleague');
INSERT INTO Preferences (ForWhom) VALUES ('Granny');
INSERT INTO Preferences (ForWhom) VALUES ('Kid');

SELECT * FROM Preferences


USE [C:\USERS\OLGA\DOCUMENTS\VISUAL STUDIO 2015\PROJECTS\FLOWERSHOP\FLOWERSHOP\FLOWERSHOP\APP_DATA\SHOPDB.MDF];

INSERT INTO City (Title, Price) VALUES ('Dnipro', 100.0000);
INSERT INTO City (Title, Price) VALUES ('Kamianske', 120.0000);
INSERT INTO City (Title, Price) VALUES ('Novomoskovsk ', 120.0000);
INSERT INTO City (Title, Price) VALUES ('Pavlograd ', 150.0000);

SELECT * FROM City

SELECT * FROM Commodities
--Flowers

INSERT INTO Commodities (id_Commodities,Title, Colour, Price, Description, IsHandMade, id_Category, Preferences, image) 
   SELECT 1 AS id_Commodities, 'Roses' AS Title, 'Red' AS Colour, 35.0000 AS Price, 
   'Red rose' AS Description, 1 AS IsHandMade, 5 AS id_Category, 'Beloved', '~/Content/Images/Comodities/Flowers/fl1.jpg';

INSERT INTO Commodities (id_Commodities,Title, Colour, Price, Description, IsHandMade, id_Category, Preferences, image) 
   SELECT 2 AS id_Commodities, 'Roses' AS Title, 'White' AS Colour, 30.0000 AS Price, 
   'White rose' AS Description, 1 AS IsHandMade, 5 AS id_Category, 'Kid','~/Content/Images/Comodities/Flowers/fl2.jpg';

INSERT INTO Commodities (id_Commodities,Title, Colour, Price, Description, IsHandMade, id_Category, Preferences, image) 
   SELECT 3 AS id_Commodities, 'Roses' AS Title, 'Pink' AS Colour, 37.0000 AS Price, 
   'Pink rose' AS Description, 1 AS IsHandMade, 5 AS id_Category, 'Mom', '~/Content/Images/Comodities/Flowers/fl3.jpg';

INSERT INTO Commodities (id_Commodities,Title, Colour, Price, Description, IsHandMade, id_Category, Preferences, image) 
   SELECT 4 AS id_Commodities, 'Roses' AS Title, 'Yellow' AS Colour, 28.0000 AS Price, 
   'Yellow rose' AS Description, 1 AS IsHandMade, 5 AS id_Category, 'Colleague', '~/Content/Images/Comodities/Flowers/fl4.jpg';


INSERT INTO Commodities (id_Commodities,Title, Colour, Price, Description, IsHandMade, id_Category, Preferences, image) 
   SELECT 5 AS id_Commodities, 'Lilies' AS Title, 'White' AS Colour, 29.0000 AS Price, 
   'White lily' AS Description, 1 AS IsHandMade, 5 AS id_Category, 'Granny', '~/Content/Images/Comodities/Flowers/fl5.jpg';

INSERT INTO Commodities (id_Commodities,Title, Colour, Price, Description, IsHandMade, id_Category, Preferences, image) 
   SELECT 6 AS id_Commodities, 'Lilies' AS Title, 'Orange' AS Colour, 24.0000 AS Price, 
   'Orange lily' AS Description, 1 AS IsHandMade, 5 AS id_Category, 'Kid', '~/Content/Images/Comodities/Flowers/fl6.jpg';

INSERT INTO Commodities (id_Commodities,Title, Colour, Price, Description, IsHandMade, id_Category, Preferences, image) 
   SELECT 7 AS id_Commodities, 'Lilies' AS Title, 'Pink' AS Colour, 22.0000 AS Price, 
   'Pink lily' AS Description, 1 AS IsHandMade, 5 AS id_Category, 'Mom', '~/Content/Images/Comodities/Flowers/fl7.jpg';

INSERT INTO Commodities (id_Commodities,Title, Colour, Price, Description, IsHandMade, id_Category, Preferences, image) 
   SELECT 8 AS id_Commodities, 'Tulips' AS Title, 'White' AS Colour, 22.0000 AS Price, 
   'White tulip' AS Description, 1 AS IsHandMade, 5 AS id_Category, 'Kid', '~/Content/Images/Comodities/Flowers/fl8.jpg';

INSERT INTO Commodities (id_Commodities,Title, Colour, Price, Description, IsHandMade, id_Category, Preferences, image) 
   SELECT 9 AS id_Commodities, 'Tulips' AS Title, 'Pink' AS Colour, 28.0000 AS Price, 
   'Pink tulip' AS Description, 1 AS IsHandMade, 5 AS id_Category, 'Colleague', '~/Content/Images/Comodities/Flowers/fl9.jpg';

INSERT INTO Commodities (id_Commodities,Title, Colour, Price, Description, IsHandMade, id_Category, Preferences, image) 
   SELECT 10 AS id_Commodities, 'Tulips' AS Title, 'Red' AS Colour, 32.0000 AS Price, 
   'Red tulip' AS Description, 1 AS IsHandMade, 5 AS id_Category, 'Beloved', '~/Content/Images/Comodities/Flowers/fl10.jpg';

INSERT INTO Commodities (id_Commodities,Title, Colour, Price, Description, IsHandMade, id_Category, Preferences, image) 
   SELECT 11 AS id_Commodities, 'Tulips' AS Title, 'Yellow' AS Colour, 30.0000 AS Price, 
   'Yellow tulip' AS Description, 1 AS IsHandMade, 5 AS id_Category, 'Colleague', '~/Content/Images/Comodities/Flowers/fl11.jpg';

INSERT INTO Commodities (id_Commodities,Title, Colour, Price, Description, IsHandMade, id_Category, Preferences, image) 
   SELECT 12 AS id_Commodities, 'Chrysanthemums' AS Title, 'White' AS Colour, 36.0000 AS Price, 
   'White chrysanthemum' AS Description, 1 AS IsHandMade, 5 AS id_Category, 'Kid', '~/Content/Images/Comodities/Flowers/fl12.jpg';

INSERT INTO Commodities (id_Commodities,Title, Colour, Price, Description, IsHandMade, id_Category, Preferences, image) 
   SELECT 13 AS id_Commodities, 'Chrysanthemums' AS Title, 'Red' AS Colour, 34.0000 AS Price, 
   'Red chrysanthemum' AS Description, 1 AS IsHandMade, 5 AS id_Category, 'Kid', '~/Content/Images/Comodities/Flowers/fl13.jpg';

INSERT INTO Commodities (id_Commodities,Title, Colour, Price, Description, IsHandMade, id_Category, Preferences, image) 
   SELECT 14 AS id_Commodities, 'Chrysanthemums' AS Title, 'Yellow' AS Colour, 34.0000 AS Price, 
   'Yellow chrysanthemum' AS Description, 1 AS IsHandMade, 5 AS id_Category, 'Colleague', '~/Content/Images/Comodities/Flowers/fl14.jpg';

INSERT INTO Commodities (id_Commodities,Title, Colour, Price, Description, IsHandMade, id_Category, Preferences, image) 
   SELECT 15 AS id_Commodities, 'Chrysanthemums' AS Title, 'Orange' AS Colour, 37.0000 AS Price, 
   'Orange chrysanthemum' AS Description, 1 AS IsHandMade, 5 AS id_Category, 'Granny', '~/Content/Images/Comodities/Flowers/fl15.jpg';

INSERT INTO Commodities (id_Commodities,Title, Colour, Price, Description, IsHandMade, id_Category, Preferences, image) 
   SELECT 16 AS id_Commodities, 'Peony' AS Title, 'Red' AS Colour, 30.0000 AS Price, 
   'Red peon' AS Description, 1 AS IsHandMade, 5 AS id_Category, 'Beloved', '~/Content/Images/Comodities/Flowers/fl16.jpg';

INSERT INTO Commodities (id_Commodities,Title, Colour, Price, Description, IsHandMade, id_Category, Preferences, image) 
   SELECT 17 AS id_Commodities, 'Peony' AS Title, 'White' AS Colour, 31.0000 AS Price, 
   'White peon' AS Description, 1 AS IsHandMade, 5 AS id_Category, 'Kid', '~/Content/Images/Comodities/Flowers/fl17.jpg';


INSERT INTO Commodities (id_Commodities,Title, Colour, Price, Description, IsHandMade, id_Category, Preferences, image) 
   SELECT 18 AS id_Commodities, 'Peony' AS Title, 'Pink' AS Colour, 30.0000 AS Price, 
   'Pink peon' AS Description, 1 AS IsHandMade, 5 AS id_Category, 'Colleague', '~/Content/Images/Comodities/Flowers/fl18.jpg';


INSERT INTO Commodities (id_Commodities,Title, Colour, Price, Description, IsHandMade, id_Category, Preferences, image) 
   SELECT 19 AS id_Commodities, 'Irises' AS Title, 'Blue' AS Colour, 36.0000 AS Price, 
   'Blue irise' AS Description, 1 AS IsHandMade, 5 AS id_Category, 'Colleague', '~/Content/Images/Comodities/Flowers/fl19.jpg';

INSERT INTO Commodities (id_Commodities,Title, Colour, Price, Description, IsHandMade, id_Category, Preferences, image) 
   SELECT 20 AS id_Commodities, 'Irises' AS Title, 'Red' AS Colour, 30.0000 AS Price, 
   'Red irise' AS Description, 1 AS IsHandMade, 5 AS id_Category, 'Beloved', '~/Content/Images/Comodities/Flowers/fl20.jpg';

INSERT INTO Commodities (id_Commodities,Title, Colour, Price, Description, IsHandMade, id_Category, Preferences, image) 
   SELECT 21 AS id_Commodities, 'Irises' AS Title, 'Yellow' AS Colour, 33.0000 AS Price, 
   'Yellow irise' AS Description, 1 AS IsHandMade, 5 AS id_Category, 'Beloved', '~/Content/Images/Comodities/Flowers/fl21.jpg';

INSERT INTO Commodities (id_Commodities,Title, Colour, Price, Description, IsHandMade, id_Category, Preferences, image) 
   SELECT 22 AS id_Commodities, 'Irises' AS Title, 'White' AS Colour, 27.0000 AS Price, 
   'White irise' AS Description, 1 AS IsHandMade, 5 AS id_Category, 'Beloved', '~/Content/Images/Comodities/Flowers/fl22.jpg';


SELECT * FROM Commodities
--Baskets

INSERT INTO Commodities (id_Commodities,Title, Colour, Price, Description, IsHandMade, id_Category, Preferences, image) 
   SELECT 23 AS id_Commodities, 'Baskets' AS Title, 'White' AS Colour, 27.0000 AS Price, 
   'Chrysanthemums basket' AS Description, 0 AS IsHandMade, 4 AS id_Category, 'Kid','~/Content/Images/Comodities/Basket/bas1.jpg' AS image;


INSERT INTO Commodities (id_Commodities,Title, Colour, Price, Description, IsHandMade, id_Category, Preferences, image) 
   SELECT 24 AS id_Commodities, 'Baskets' AS Title, 'Mixed' AS Colour, 27.0000 AS Price, 
   'Lilies basket' AS Description, 0 AS IsHandMade, 4 AS id_Category, 'Granny', '~/Content/Images/Comodities/Basket/bas2.jpg' AS image;

INSERT INTO Commodities (id_Commodities,Title, Colour, Price, Description, IsHandMade, id_Category, Preferences, image) 
   SELECT 25 AS id_Commodities, 'Baskets' AS Title, 'Red' AS Colour, 27.0000 AS Price, 
   'Roses basket' AS Description, 0 AS IsHandMade, 4 AS id_Category, 'Mom','~/Content/Images/Comodities/Basket/bas3.jpg' as image;

INSERT INTO Commodities (id_Commodities,Title, Colour, Price, Description, IsHandMade, id_Category, Preferences, image) 
   SELECT 26 AS id_Commodities, 'Baskets' AS Title, 'Mixed' AS Colour, 27.0000 AS Price, 
   'Roses basket' AS Description, 0 AS IsHandMade, 4 AS id_Category, 'Colleaugue', '~/Content/Images/Comodities/Basket/bas4.jpg' as image;

INSERT INTO Commodities (id_Commodities,Title, Colour, Price, Description, IsHandMade, id_Category, Preferences, image) 
   SELECT 27 AS id_Commodities, 'Baskets' AS Title, 'Mixed' AS Colour, 27.0000 AS Price, 
   'Sunflowers basket' AS Description, 0 AS IsHandMade, 4 AS id_Category, 'Beloved', '~/Content/Images/Comodities/Basket/bas5.jpg' as image;

INSERT INTO Commodities (id_Commodities,Title, Colour, Price, Description, IsHandMade, id_Category, Preferences, image) 
   SELECT 28 AS id_Commodities, 'Baskets' AS Title, 'Mixed' AS Colour, 27.0000 AS Price, 
   'Roses basket' AS Description, 0 AS IsHandMade, 4 AS id_Category, 'Colleague','~/Content/Images/Comodities/Basket/bas6.jpg' as image;

INSERT INTO Commodities (id_Commodities,Title, Colour, Price, Description, IsHandMade, id_Category, Preferences, image) 
   SELECT 29 AS id_Commodities, 'Baskets' AS Title, 'White' AS Colour, 27.0000 AS Price, 
   'Chamomiles basket' AS Description, 0 AS IsHandMade, 4 AS id_Category, 'Kid', '~/Content/Images/Comodities/Basket/bas7.jpg' as image;

INSERT INTO Commodities (id_Commodities,Title, Colour, Price, Description, IsHandMade, id_Category, Preferences, image) 
   SELECT 30 AS id_Commodities, 'Baskets' AS Title, 'Mixed' AS Colour, 27.0000 AS Price, 
   'Chrysanthemums basket' AS Description, 0 AS IsHandMade, 4 AS id_Category, 'Mom','~/Content/Images/Comodities/Basket/bas8.jpg' as image;

INSERT INTO Commodities (id_Commodities,Title, Colour, Price, Description, IsHandMade, id_Category, Preferences, image) 
   SELECT 31 AS id_Commodities, 'Baskets' AS Title, 'Mixed' AS Colour, 27.0000 AS Price, 
   'Chrysanthemums basket' AS Description, 0 AS IsHandMade, 4 AS id_Category, 'Beloved', '~/Content/Images/Comodities/Basket/bas9.jpg' as image;

INSERT INTO Commodities (id_Commodities,Title, Colour, Price, Description, IsHandMade, id_Category, Preferences, image) 
   SELECT 32 AS id_Commodities, 'Baskets' AS Title, 'Mixed' AS Colour, 27.0000 AS Price, 
   'Chamomiles basket' AS Description, 0 AS IsHandMade, 4 AS id_Category, 'Colleague', '~/Content/Images/Comodities/Basket/bas10.jpg' as image;

INSERT INTO Commodities (id_Commodities,Title, Colour, Price, Description, IsHandMade, id_Category, Preferences, image) 
   SELECT 33 AS id_Commodities, 'Baskets' AS Title, 'Mixed' AS Colour, 27.0000 AS Price, 
   'Chamomiles basket' AS Description, 0 AS IsHandMade, 4 AS id_Category, 'Beloved','~/Content/Images/Comodities/Basket/bas11.jpg' as image;

--Bouquets

INSERT INTO Commodities (id_Commodities,Title, Colour, Price, Description, IsHandMade, id_Category, Preferences, image) 
   SELECT 34 AS id_Commodities, 'Bouquets' AS Title, 'Mixed' AS Colour, 370.0000 AS Price, 
   'Chamomiles bouquet' AS Description, 0 AS IsHandMade, 3 AS id_Category, 'Granny', '~/Content/Images/Comodities/Bouquet/compos1.jpg' as image;

INSERT INTO Commodities (id_Commodities,Title, Colour, Price, Description, IsHandMade, id_Category, Preferences, image) 
   SELECT 35 AS id_Commodities, 'Bouquets' AS Title, 'Mixed' AS Colour,350.0000 AS Price, 
   'Roses bouquet' AS Description, 0 AS IsHandMade, 3 AS id_Category, 'Beloved','~/Content/Images/Comodities/Bouquet/compos2.jpg' as image;

INSERT INTO Commodities (id_Commodities,Title, Colour, Price, Description, IsHandMade, id_Category, Preferences, image) 
   SELECT 36 AS id_Commodities, 'Bouquets' AS Title, 'Mixed' AS Colour, 430.0000 AS Price, 
   'Tulips bouquet' AS Description, 0 AS IsHandMade, 3 AS id_Category, 'Kid', '~/Content/Images/Comodities/Bouquet/compos3.jpg' as image;

INSERT INTO Commodities (id_Commodities,Title, Colour, Price, Description, IsHandMade, id_Category, Preferences, image) 
   SELECT 37 AS id_Commodities, 'Bouquets' AS Title, 'Mixed' AS Colour, 450.0000 AS Price, 
   'Roses bouquet' AS Description, 0 AS IsHandMade, 3 AS id_Category, 'Mom', '~/Content/Images/Comodities/Bouquet/compos4.jpg' as image;

INSERT INTO Commodities (id_Commodities,Title, Colour, Price, Description, IsHandMade, id_Category, Preferences, image) 
   SELECT 38 AS id_Commodities, 'Bouquets' AS Title, 'Mixed' AS Colour, 500.0000 AS Price, 
   'Sunflowers bouquet' AS Description, 0 AS IsHandMade, 3 AS id_Category, 'Colleague', '~/Content/Images/Comodities/Bouquet/compos5.jpg' as image;

INSERT INTO Commodities (id_Commodities,Title, Colour, Price, Description, IsHandMade, id_Category, Preferences, image) 
   SELECT 39 AS id_Commodities, 'Bouquets' AS Title, 'Mixed' AS Colour, 190.0000 AS Price, 
   'Lilies bouquet' AS Description, 0 AS IsHandMade, 3 AS id_Category, 'Kid', '~/Content/Images/Comodities/Bouquet/compos6.jpg' as image;

INSERT INTO Commodities (id_Commodities,Title, Colour, Price, Description, IsHandMade, id_Category, Preferences, image) 
   SELECT 40 AS id_Commodities, 'Bouquets' AS Title, 'Yellow' AS Colour, 200.0000 AS Price, 
   'Chamomiles bouquet' AS Description, 0 AS IsHandMade, 3 AS id_Category, 'Granny', '~/Content/Images/Comodities/Bouquet/compos7.jpg' as image;


INSERT INTO Commodities (id_Commodities,Title, Colour, Price, Description, IsHandMade, id_Category, Preferences, image) 
   SELECT 41 AS id_Commodities, 'Bouquets' AS Title, 'Mixed' AS Colour, 400.0000 AS Price, 
   'Roses bouquet' AS Description, 0 AS IsHandMade, 3 AS id_Category, 'Beloved', '~/Content/Images/Comodities/Bouquet/compos8.jpg' as image;

INSERT INTO Commodities (id_Commodities,Title, Colour, Price, Description, IsHandMade, id_Category, Preferences, image) 
   SELECT 42 AS id_Commodities, 'Bouquets' AS Title, 'Mixed' AS Colour, 350.0000 AS Price, 
   'Roses bouquet' AS Description, 0 AS IsHandMade, 3 AS id_Category, 'Colleague', '~/Content/Images/Comodities/Bouquet/compos9.jpg' as image;

INSERT INTO Commodities (id_Commodities,Title, Colour, Price, Description, IsHandMade, id_Category, Preferences, image) 
   SELECT 43 AS id_Commodities, 'Bouquets' AS Title, 'Mixed' AS Colour, 270.0000 AS Price, 
   'Roses bouquet' AS Description, 0 AS IsHandMade, 3 AS id_Category, 'Mom', '~/Content/Images/Comodities/Bouquet/compos10.jpg' as image;

INSERT INTO Commodities (id_Commodities,Title, Colour, Price, Description, IsHandMade, id_Category, Preferences, image) 
   SELECT 44 AS id_Commodities, 'Bouquets' AS Title, 'Mixed' AS Colour, 210.0000 AS Price, 
   'Chamomiles bouquet' AS Description, 0 AS IsHandMade, 3 AS id_Category, 'Granny', '~/Content/Images/Comodities/Bouquet/compos11.jpg' as image;

Select * from Commodities

--Compositions

INSERT INTO Commodities (id_Commodities,Title, Colour, Price, Description, IsHandMade, id_Category, Preferences, image) 
   SELECT 45 AS id_Commodities, 'Composition' AS Title, 'Blue' AS Colour, 2500.0000 AS Price, 
   'Bear 1' AS Description, 0 AS IsHandMade, 1 AS id_Category, 'Beloved', '~/Content/Images/Comodities/Composition/comp1.jpg' as image;

INSERT INTO Commodities (id_Commodities,Title, Colour, Price, Description, IsHandMade, id_Category, Preferences, image) 
   SELECT 46 AS id_Commodities, 'Composition' AS Title, 'White' AS Colour, 2700.0000 AS Price, 
   'Chebur' AS Description, 0 AS IsHandMade, 1 AS id_Category, 'Kid', '~/Content/Images/Comodities/Composition/comp2.jpg' as image;

INSERT INTO Commodities (id_Commodities,Title, Colour, Price, Description, IsHandMade, id_Category, Preferences, image) 
   SELECT 47 AS id_Commodities, 'Composition' AS Title, 'Mixed' AS Colour, 3000.0000 AS Price, 
   'Butterfly' AS Description, 0 AS IsHandMade, 1 AS id_Category, 'Colleague', '~/Content/Images/Comodities/Composition/comp3.jpg' as image;

INSERT INTO Commodities (id_Commodities,Title, Colour, Price, Description, IsHandMade, id_Category, Preferences, image) 
   SELECT 48 AS id_Commodities, 'Composition' AS Title, 'Mixed' AS Colour, 2400.0000 AS Price, 
   'Hedgehog' AS Description, 0 AS IsHandMade, 1 AS id_Category, 'Granny', '~/Content/Images/Comodities/Composition/comp4.jpg' as image;

INSERT INTO Commodities (id_Commodities,Title, Colour, Price, Description, IsHandMade, id_Category, Preferences, image) 
   SELECT 49 AS id_Commodities, 'Composition' AS Title, 'White' AS Colour, 2900.0000 AS Price, 
   'Bear 2' AS Description, 0 AS IsHandMade, 1 AS id_Category, 'Mom', '~/Content/Images/Comodities/Composition/comp5.jpg' as image;

INSERT INTO Commodities (id_Commodities,Title, Colour, Price, Description, IsHandMade, id_Category, Preferences, image) 
   SELECT 50 AS id_Commodities, 'Composition' AS Title, 'Yellow' AS Colour, 3200.0000 AS Price, 
   'Bear 3' AS Description, 0 AS IsHandMade, 1 AS id_Category, 'Beloved', '~/Content/Images/Comodities/Composition/comp6.jpg' as image;

INSERT INTO Commodities (id_Commodities,Title, Colour, Price, Description, IsHandMade, id_Category, Preferences, image) 
   SELECT 51 AS id_Commodities, 'Composition' AS Title, 'Yellow' AS Colour, 3400.0000 AS Price, 
   'Lion' AS Description, 0 AS IsHandMade, 1 AS id_Category, 'Kid', '~/Content/Images/Comodities/Composition/comp7.jpg' as image;

INSERT INTO Commodities (id_Commodities,Title, Colour, Price, Description, IsHandMade, id_Category, Preferences, image) 
   SELECT 52 AS id_Commodities, 'Composition' AS Title, 'White' AS Colour, 3000.0000 AS Price, 
   'Dog' AS Description, 0 AS IsHandMade, 1 AS id_Category, 'Colleague', '~/Content/Images/Comodities/Composition/comp8.jpg' as image;

Select * from Commodities
--Decoration

INSERT INTO Commodities (id_Commodities,Title, Colour, Price, Description, IsHandMade, id_Category, Preferences, image) 
   SELECT 53 AS id_Commodities, 'Decoration' AS Title, 'Mixed' AS Colour, 30.0000 AS Price, 
   'Paper 1' AS Description, 1 AS IsHandMade, 7 AS id_Category, 'Colleague', '~/Content/Images/Comodities/Decoration/dec1.jpg' as image;

INSERT INTO Commodities (id_Commodities,Title, Colour, Price, Description, IsHandMade, id_Category, Preferences, image) 
   SELECT 54 AS id_Commodities, 'Decoration' AS Title, 'Mixed' AS Colour, 30.0000 AS Price, 
   'Paper 2' AS Description, 1 AS IsHandMade, 7 AS id_Category, 'Kid', '~/Content/Images/Comodities/Decoration/dec2.jpg' as image;

INSERT INTO Commodities (id_Commodities,Title, Colour, Price, Description, IsHandMade, id_Category, Preferences, image) 
   SELECT 55 AS id_Commodities, 'Decoration' AS Title, 'Mixed' AS Colour, 30.0000 AS Price, 
   'Paper 3' AS Description, 1 AS IsHandMade, 7 AS id_Category, 'Mom', '~/Content/Images/Comodities/Decoration/dec3.jpg' as image;

INSERT INTO Commodities (id_Commodities,Title, Colour, Price, Description, IsHandMade, id_Category, Preferences, image) 
   SELECT 56 AS id_Commodities, 'Decoration' AS Title, 'Mixed' AS Colour, 56.0000 AS Price, 
   'Basket 1' AS Description, 1 AS IsHandMade, 7 AS id_Category, 'Mom', '~/Content/Images/Comodities/Decoration/dec4.jpg' as image;

INSERT INTO Commodities (id_Commodities,Title, Colour, Price, Description, IsHandMade, id_Category, Preferences, image) 
   SELECT 57 AS id_Commodities, 'Decoration' AS Title, 'Mixed' AS Colour, 51.0000 AS Price, 
   'Basket 2' AS Description, 1 AS IsHandMade, 7 AS id_Category, 'Beloved', '~/Content/Images/Comodities/Decoration/dec5.jpg' as image;

INSERT INTO Commodities (id_Commodities,Title, Colour, Price, Description, IsHandMade, id_Category, Preferences, image) 
   SELECT 58 AS id_Commodities, 'Decoration' AS Title, 'Mixed' AS Colour, 53.0000 AS Price, 
   'Basket 3' AS Description, 1 AS IsHandMade, 7 AS id_Category, 'Granny', '~/Content/Images/Comodities/Decoration/dec6.jpg' as image;

INSERT INTO Commodities (id_Commodities,Title, Colour, Price, Description, IsHandMade, id_Category, Preferences, image) 
   SELECT 59 AS id_Commodities, 'Decoration' AS Title, 'Mixed' AS Colour, 55.0000 AS Price, 
   'Basket 4' AS Description, 1 AS IsHandMade, 7 AS id_Category, 'Colleague', '~/Content/Images/Comodities/Decoration/dec7.jpg' as image;

INSERT INTO Commodities (id_Commodities,Title, Colour, Price, Description, IsHandMade, id_Category, Preferences, image) 
   SELECT 60 AS id_Commodities, 'Decoration' AS Title, 'White' AS Colour, 57.0000 AS Price, 
   'Basket 5' AS Description, 1 AS IsHandMade, 7 AS id_Category, 'Beloved', '~/Content/Images/Comodities/Decoration/dec8.jpg' as image;

INSERT INTO Commodities (id_Commodities,Title, Colour, Price, Description, IsHandMade, id_Category, Preferences, image) 
   SELECT 61 AS id_Commodities, 'Decoration' AS Title, 'White' AS Colour, 52.0000 AS Price, 
   'Basket 6' AS Description, 1 AS IsHandMade, 7 AS id_Category, 'Kid', '~/Content/Images/Comodities/Decoration/dec9.jpg' as image;

Select * from Commodities


--Grass
INSERT INTO Commodities (id_Commodities,Title, Colour, Price, Description, IsHandMade, id_Category, Preferences, image) 
   SELECT 62 AS id_Commodities, 'Grass' AS Title, 'Green' AS Colour, 12.0000 AS Price, 
   'Grass 1' AS Description, 1 AS IsHandMade, 6 AS id_Category, 'Kid', '~/Content/Images/Comodities/Grass/gr1.jpg' as image;

INSERT INTO Commodities (id_Commodities,Title, Colour, Price, Description, IsHandMade, id_Category, Preferences, image) 
   SELECT 63 AS id_Commodities, 'Grass' AS Title, 'Green' AS Colour, 13.0000 AS Price, 
   'Grass 2' AS Description, 1 AS IsHandMade, 6 AS id_Category, 'Mom', '~/Content/Images/Comodities/Grass/gr2.jpg' as image;

INSERT INTO Commodities (id_Commodities,Title, Colour, Price, Description, IsHandMade, id_Category, Preferences, image) 
   SELECT 64 AS id_Commodities, 'Grass' AS Title, 'Green' AS Colour, 14.0000 AS Price, 
   'Grass 3' AS Description, 1 AS IsHandMade, 6 AS id_Category, 'Colleague', '~/Content/Images/Comodities/Grass/gr3.jpg' as image;

INSERT INTO Commodities (id_Commodities,Title, Colour, Price, Description, IsHandMade, id_Category, Preferences, image) 
   SELECT 65 AS id_Commodities, 'Grass' AS Title, 'Green' AS Colour, 16.0000 AS Price, 
   'Grass 4' AS Description, 1 AS IsHandMade, 6 AS id_Category, 'Beloved', '~/Content/Images/Comodities/Grass/gr4.jpg' as image;


INSERT INTO Commodities (id_Commodities,Title, Colour, Price, Description, IsHandMade, id_Category, Preferences, image) 
   SELECT 66 AS id_Commodities, 'Grass' AS Title, 'Green' AS Colour, 11.0000 AS Price, 
   'Grass 5' AS Description, 1 AS IsHandMade, 6 AS id_Category, 'Granny', '~/Content/Images/Comodities/Grass/gr5.jpg' as image;

INSERT INTO Commodities (id_Commodities,Title, Colour, Price, Description, IsHandMade, id_Category, Preferences, image) 
   SELECT 67 AS id_Commodities, 'Grass' AS Title, 'Green' AS Colour, 10.0000 AS Price, 
   'Grass 6' AS Description, 1 AS IsHandMade, 6 AS id_Category, 'Coleague', '~/Content/Images/Comodities/Grass/gr6.jpg' as image;

INSERT INTO Commodities (id_Commodities,Title, Colour, Price, Description, IsHandMade, id_Category, Preferences, image) 
   SELECT 68 AS id_Commodities, 'Grass' AS Title, 'Green' AS Colour, 15.0000 AS Price, 
   'Grass 7' AS Description, 1 AS IsHandMade, 6 AS id_Category, 'Mom', '~/Content/Images/Comodities/Grass/gr7.jpg' as image;

INSERT INTO Commodities (id_Commodities,Title, Colour, Price, Description, IsHandMade, id_Category, Preferences, image) 
   SELECT 69 AS id_Commodities, 'Grass' AS Title, 'Green' AS Colour, 16.0000 AS Price, 
   'Grass 8' AS Description, 1 AS IsHandMade, 6 AS id_Category, 'Beloved', '~/Content/Images/Comodities/Grass/gr8.jpg' as image;

INSERT INTO Commodities (id_Commodities,Title, Colour, Price, Description, IsHandMade, id_Category, Preferences, image) 
   SELECT 70 AS id_Commodities, 'Grass' AS Title, 'Green' AS Colour, 17.0000 AS Price, 
   'Grass 9' AS Description, 1 AS IsHandMade, 6 AS id_Category, 'Kid', '~/Content/Images/Comodities/Grass/gr9.jpg' as image;

Select * from Commodities


--Mono

INSERT INTO Commodities (id_Commodities,Title, Colour, Price, Description, IsHandMade, id_Category, Preferences, image) 
   SELECT 71 AS id_Commodities, 'Mono Bouquets' AS Title, 'Pink' AS Colour, 310.0000 AS Price, 
   'Mono 1' AS Description, 0 AS IsHandMade, 2 AS id_Category, 'Kid', '~/Content/Images/Comodities/Mono/mono1.jpg' as image;

INSERT INTO Commodities (id_Commodities,Title, Colour, Price, Description, IsHandMade, id_Category, Preferences, image) 
   SELECT 72 AS id_Commodities, 'Mono Bouquets' AS Title, 'White' AS Colour, 340.0000 AS Price, 
   'Mono 2' AS Description, 0 AS IsHandMade, 2 AS id_Category, 'Granny', '~/Content/Images/Comodities/Mono/mono2.jpg' as image;

INSERT INTO Commodities (id_Commodities,Title, Colour, Price, Description, IsHandMade, id_Category, Preferences, image) 
   SELECT 73 AS id_Commodities, 'Mono Bouquets' AS Title, 'Pink' AS Colour, 270.0000 AS Price, 
   'Mono 3' AS Description, 0 AS IsHandMade, 2 AS id_Category, 'Colleague', '~/Content/Images/Comodities/Mono/mono3.jpg' as image;

INSERT INTO Commodities (id_Commodities,Title, Colour, Price, Description, IsHandMade, id_Category, Preferences, image) 
   SELECT 74 AS id_Commodities, 'Mono Bouquets' AS Title, 'Red' AS Colour, 390.0000 AS Price, 
   'Mono 4' AS Description, 0 AS IsHandMade, 2 AS id_Category, 'Beloved', '~/Content/Images/Comodities/Mono/mono4.jpg' as image;

INSERT INTO Commodities (id_Commodities,Title, Colour, Price, Description, IsHandMade, id_Category, Preferences, image) 
   SELECT 75 AS id_Commodities, 'Mono Bouquets' AS Title, 'White' AS Colour, 280.0000 AS Price, 
   'Mono 5' AS Description, 0 AS IsHandMade, 2 AS id_Category, 'Granny', '~/Content/Images/Comodities/Mono/mono5.jpg' as image;

INSERT INTO Commodities (id_Commodities,Title, Colour, Price, Description, IsHandMade, id_Category, Preferences, image) 
   SELECT 76 AS id_Commodities, 'Mono Bouquets' AS Title, 'Yellow' AS Colour, 280.0000 AS Price, 
   'Mono 6' AS Description, 0 AS IsHandMade, 2 AS id_Category, 'Colleague', '~/Content/Images/Comodities/Mono/mono6.jpg' as image;

INSERT INTO Commodities (id_Commodities,Title, Colour, Price, Description, IsHandMade, id_Category, Preferences, image) 
   SELECT 77 AS id_Commodities, 'Mono Bouquets' AS Title, 'Blue' AS Colour, 300.0000 AS Price, 
   'Mono 7' AS Description, 0 AS IsHandMade, 2 AS id_Category, 'Mom', '~/Content/Images/Comodities/Mono/mono7.jpg' as image;

Select * from Commodities

USE [C:\USERS\OLGA\DOCUMENTS\VISUAL STUDIO 2015\PROJECTS\FLOWERSHOP\FLOWERSHOP\FLOWERSHOP\APP_DATA\SHOPDB.MDF];
DELETE FROM Commodities


SELECT * FROM Commodities



SELECT * FROM Client

INSERT INTO Client (Name, CellPhone, Email, Gender, Age, id_City)
VALUES ('Alex', '0953336885', 'alex@mail.com', 'male', 24, 1)