const { data } = require("jquery");

var dataTable;
$(document).ready(function () {
    loadDataTable();
})

function loadDataTable() {
    dataTable = $('#tblData').DataTable({
        "ajax": {
            "url": "/Admin/Company/GetAll"
        },
        "columns": [
            { "data": "name", "width": "10%" },
            { "data": "streetAddress", "width": "15%" },
            { "data": "city", "width": "10%" },
            { "data": "state", "width": "10%" },
            { "data": "phoneNumber", "width": "15%" },
            {
                "data": "isAuthorirzedCompany",
                "render": function (data) {
                    if (data) {
                        return `<input type="checkbox" disabled checked/>`
                    }
                    else {
                        return `<input type="checkbox" disabled />`
                    }
                }
            },
            {
                "data": "id",
                "render": function (data) {
                    return `
                          <div class="text-center">
                          <a class="btn btn-success" href="/Admin/Company/Upsert/${data}">
                          <i class="fas fa-edit"></i> Edit
                          </a>
                          <a class="btn btn-danger" onclick=Delete("/Admin/Company/Delete/${data}")>
                          <i class="fas fa-trash"></i> Delete
                          </a>
                          </div>
                    `;
                }
            }
        ]
    })

    abcd(data);
}

function abcd(data) {

}

function Delete(url) {
    swal({
        title: "Want To Delete Data!!!",
        icon: "error",
        buttons: true,
        text: "Delete Information!!!",
        dangerModel: true
    }).then((willdelete) => {
        if (willdelete) {
            $.ajax({
                url: url,
                type: "Delete",
                success: function (data) {
                    if (data.success) {
                        toastr.success(data.mesage)
                        data.ajax.reload();
                    }
                    else {
                        toastr.error(data.message);
                    }
                }
            })
        }
    })
}