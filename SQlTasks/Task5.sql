WITH CheapestCars AS (
    SELECT 
        BrandID,
        MIN(Price) AS MinPrice
    FROM 
        Cars
    GROUP BY 
        BrandID
)
SELECT 
    cars.Name AS CarName,
    brands.Name AS BrandName
FROM 
    Cars cars
JOIN 
    CheapestCars cheapest_cars ON cars.BrandID = cheapest_cars.BrandID AND cars.Price = cheapest_cars.MinPrice
JOIN 
    Brands brands ON cars.BrandID = brands.ID;
