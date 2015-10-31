//add front end message options. this code 
$(function () {
	toastr.options = {
		"closeButton": true,
		"debug": false,
		"positionClass": "toast-top-right",
		"onclick": null,
		"showDuration": "300",
		"hideDuration": "1000",
		"timeOut": "5000",
		"extendedTimeOut": "1000",
		"showEasing": "swing",
		"hideEasing": "linear",
		"showMethod": "fadeIn",
		"hideMethod": "fadeOut"
	}
	var stickyOverride = { timeOut: 0, extendedTimeOut: 0 }

	//on load, look for these various div classes and make messages
	//allows back end to pass messages to front end
	$('.msgSuccess').each(function () {
		toastr.success(this.innerHTML);
	});
	$('.msgInfo').each(function () {
		toastr.info(this.innerHTML);
	});

	$('.msgWarning').each(function () {
		var overrides =
        toastr.warning(this.innerHTML, "Warning!", stickyOverride);
	});
	$('.msgError').each(function () {
		toastr.error(this.innerHTML, "Error!", stickyOverride);
	});

	//if (messageList) {
	//	$.each(messageList, function (index, obj) {
	//		switch (obj.Type) {
	//			case "Success":
	//				toastr.success(obj.Text);
	//				break;
	//			case "Info":
	//				toastr.info(obj.Text);
	//				break;
	//			case "Warning":
	//				toastr.warning(obj.Text, "Warning!", stickyOverride);
	//				break;
	//			case "Error":
	//				toastr.error(obj.Text, "Error!", stickyOverride);
	//				break;
	//			default:
	//				toastr.info(obj.Text, obj.Type, stickyOverride);
	//				break;
	//		};
	//	});
	//}
});

//abstracting here so we can use other libraries for methods
var msg= {
	success: function(message, title, optionsOverride) {
		return toastr.success(message, title, optionsOverride);
	},
	error: function(message, title, optionsOverride) {
		return toastr.error(message, title, optionsOverride);
	},
	warning: function (message, title, optionsOverride) {
		return toastr.warning(message, title, optionsOverride);
	},
	info: function (message, title, optionsOverride) {
		return toastr.success(message, title, optionsOverride);
	}
}

///* global define */
//(function (define) {
//	define(['jquery'], function ($) {
//		return (function () {
//			var $container;
//			var listener;
//			var msg = {

//			};

//			return msg;

//			////////////////

//			function error(message, title, optionsOverride) {
//				return toastr.error(message, title, optionsOverride);
//			}

//			function info(message, title, optionsOverride) {
//				return toastr.info(message, title, optionsOverride);
//			}

//			function success(message, title, optionsOverride) {
//				return toastr.success(message, title, optionsOverride);
//			}

//			function warning(message, title, optionsOverride) {
//				return toastr.warning(message, title, optionsOverride);
//			}
//			// internal functions

//			function publish(args) {
//				if (!listener) { return; }
//				listener(args);
//			}
//		})();
//	});
//}(typeof define === 'function' && define.amd ? define : function (deps, factory) {
//	if (typeof module !== 'undefined' && module.exports) { //Node
//		module.exports = factory(require('jquery'));
//	} else {
//		window.msg = factory(window.jQuery);
//	}
//}));