select Student_
from tbl_Entry_new_book
where Book_ID in 
(
	select Book_ID
	from tbl_Due_Books
	where Student_ID = '140201'
)