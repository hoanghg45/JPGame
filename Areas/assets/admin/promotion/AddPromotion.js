﻿////(function Module() {


////})()

"use strict";

// Class Definition
var Add = function () {




    var _handleSignInForm = function () {
        var validation;
        const form = document.getElementById('PromotionForm');
        // Init form validation rules. For more info check the FormValidation plugin's official documentation:https://formvalidation.io/
        validation = FormValidation.formValidation(
            KTUtil.getById('PromotionForm'),
            {
                fields: {
                    Title: {
                        validators: {
                            notEmpty: {
                                message: 'Vui lòng nhập tiêu đề'
                            },

                        }
                    },

                    Content: {
                        validators: {
                            notEmpty: {
                                message: 'Vui lòng nhập nội dung',

                            },
                            
                        }
                    },
                    Rate: {
                        validators: {
                            notEmpty: {
                                message: 'Vui lòng nhập tỉ lệ khuyến mãi'
                            },
                            integer: {
                                message: 'Tỉ lệ khuyến mãi không hợp lệ',
                                // The default separators
                                thousandsSeparator: '',
                                decimalSeparator: '.',
                            },
                            between: {
                                min: 0,
                                max: 99999999,
                                message: 'Tỉ lệ khuyến mãi không hợp lệ',
                            },
                        }
                    },
                  

                },

                plugins: {
                    trigger: new FormValidation.plugins.Trigger(),
                    submitButton: new FormValidation.plugins.SubmitButton(),
                    //defaultSubmit: new FormValidation.plugins.DefaultSubmit(), // Uncomment this line to enable normal button submit after form validation
                    bootstrap: new FormValidation.plugins.Bootstrap(),
                    icon: new FormValidation.plugins.Icon({
                        valid: 'fa fa-check',
                        invalid: 'fa fa-times',
                        validating: 'fa fa-refresh',
                    }),
                }
            }
        );


        $('.btnCreate').click(function () {
            let data = $('#PromotionForm').serialize()
            
            validation.validate().then(function (status) {
                if (status == 'Valid') {
                    AddModule(data)
                } else {
                    toastr.error('Vui lòng điền thông tin đầy đủ và hợp lệ!')
                        .then(function () {
                        KTUtil.scrollTop();
                    });
                }
            });

        })




        function AddModule(data) {
            $.ajax({
                type: "POST",
                url: "/PromotionAdmin/CreatePromotion",
                data: data,
                datatype: "json",
                success: function (result) {
                    if (result.status == "success") {
                        toastr.success('Thành công!')
                        window.location.href = "/Admin/PromotionAdmin"
                    } else {
                        
                        toastr.error('Đã có lỗi xảy ra, vui lòng thử lại!', result.message)
                    }
                },
                error: function () {
                    toastr.error('Đã có lỗi xảy ra, vui lòng thử lại!')
                }
            })
        }
    }



    // Public Functions
    return {
        // public functions
        init: function () {


            _handleSignInForm();

        }
    };
}();

// Class Initialization
jQuery(document).ready(function () {
    Add.init();
});