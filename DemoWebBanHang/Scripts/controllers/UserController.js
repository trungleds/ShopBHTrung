var UserControler = {
    init: function () {
        UserControler.loadData();
        UserControler.registerEvent();

    },
    registerEvent: function () {
        $('btnAddNew').on('click', function () {
            $('#modalAddUpdate').modal('show');
            UserControler.resetForm();
        })
        $('#btnSave').off('click').on('click', function () {
            UserControler.saveData();
        })
    },

    saveData : function() {
        var userName = $('txtUsername').val();
        var password = $('txtUsername').val();
        var name = $('txtUsername').val();
        var addess = $('txtAddess').val();
        var phone = $('txtUsername').val();
        var email = $('txtUsername').val();
        var status = $('chexboxStatus').prop('checked');
        var id = parseint($('hidID').val());
        $.ajax({
            url: '/User/SaveData',
            data: {
                employee: {
                    UserName: userName,
                    Password: password,
                    Name: name,
                    Addess: addess,
                    Phone: phone,
                    Email: email,
                    Status: status,
                    ID:id 
                    }
            },
            type: 'POST',
            dataType: 'json',
            success: function (response) {
                if (status == true) {
                    alert('Save success');
                    $('#modalAddUpdate').modal('hide');
                }
                else {
                    alert(response.Message);
                }
            },
            error: function (err) {
                console.log(err);
            }
            })


    },
    resetForm: function () {
        $('txtUsername').val('0');
        $('txtPassword').val('0');
        $('txtAddess').val('0');
        $('txtName').val('0');
        $('txtEmail').val('0');
        $('txtPhone').val('0');
        $('chexboxStatus').prop('checked',true);


    }
    }