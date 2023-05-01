import png
import math

r = png.Reader(filename="Background.png")
(w, h, v, i) = r.read_flat()
del i["size"]
del i["physical"]
writer = png.Writer(1024, h, **i)
#writer = png.Writer(w, h, **i)

#import pdb;pdb.set_trace()

files = [open(str(x) + ".png", "wb") for x in range(1, math.ceil(w/1024.0))]

for fi in range(len(files)):
    fRows = []
    for r in range(h):
        # RGBA -> 1024 * 4
        fRows.extend(v[fi * 4096 + r * w * 4:(fi + 1) * 4096 + r * w * 4])
    writer.write_array(files[fi], fRows)
    files[fi].close()
