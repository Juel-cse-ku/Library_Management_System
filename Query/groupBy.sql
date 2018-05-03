select Category, sum(Quantity)
from tbl_Entry_new_book
group by Category