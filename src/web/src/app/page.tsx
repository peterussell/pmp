import Image from 'next/image';

export default function Home() {
  return (
    <div className="
      w-full
      flex
      flex-col
      justify-center items-center p-4">
      <Image src="/flightsim.jpg" width={300} height={400} alt="For your high-tech flight sim needs" />
      <span>(credit <a href="https://www.flickr.com/photos/8399025@N07/">Marcin Wichary</a>)</span>
    </div>
  )
}
