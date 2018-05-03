select Name
from tbl_Student_Information
where Student_ID in
	(
	select Student_ID
	from tbl_Due_Books
	where Book_ID in
		(
		select Book_ID
		from tbl_Entry_new_book
		where Book_Name='C The Complete Reference'
		)
	)