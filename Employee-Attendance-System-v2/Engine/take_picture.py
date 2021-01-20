import cv2
import os
import pymongo

cam = cv2.VideoCapture(0)

cv2.namedWindow("Capture Pictures")

img_counter = 0

# Collect info from student
student_name = input("Enter the full name of the employee : ")
os.mkdir("./train_img/"+student_name)

#insert student in database
myclient = pymongo.MongoClient("mongodb://localhost:27017/")
mydb = myclient["proj1db"]
mycol = mydb["students"]

while True and img_counter <= 30:
    ret, frame = cam.read()
    cv2.imshow("test", frame)
    if not ret:
        break
    k = cv2.waitKey(1)

    if k%256 == 27:
        # ESC pressed
        print("Escape hit, closing...")
        break
    elif k%256 == 32:
        # SPACE pressed
        img_name = "ActiOn_{}.jpg".format(img_counter)
        # cv2.imwrite(img_name, frame)
        cv2.imwrite("train_img/"+student_name+"/"+img_name, frame)
        print("{} written!".format(img_name))
        img_counter += 1

print(student_name + " is inserted on database")

cam.release()

cv2.destroyAllWindows()