export const Footer = () => {
    return (
        <div className="
            bg-pmpBlueDark
            w-full
            p-2
            flex
            items-center
            justify-center">
            <p className='text-pmpWhite'>&copy; { new Date().getFullYear() }</p>
        </div>
    );
};
