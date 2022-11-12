--рабочий запрос к вопросу № 3
use Testing_Task_MINDBOX;
select Products.Name as Product_Name, Categories.Name as Category_Name from Products
left join Product_Category on Products.ID = Product_Category.Product_ID
left join Categories on Categories.ID = Product_Category.Category_ID;