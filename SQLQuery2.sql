select self_number
from tbl_Book_Self
where Book_ID in
{
 select Book_Name
 from  tbl_Entry_new_book
 where Self_ID.Book_Name= Book_ID.Book_Name
}
