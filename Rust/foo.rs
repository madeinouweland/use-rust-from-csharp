#![crate_type = "lib"]
#[no_mangle]
pub extern "C" fn foo(value1 : u32, value2 : u32) -> u32 {
	println!("Hello from rust. Let me calculate for you!");
	value1 + value2
}