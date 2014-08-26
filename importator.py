import os, sys
###########SOME FUNCTIONS###################################
def export_from_DEV():
        rtc = raw_input('Insert RTC number\n')

        if not os.path.exists('/tmp/premium/'):
                print '/tmp/premium folder not exists, -not a problem, creating and proceeding...\n'
                os.makedirs('/tmp/premium/')

        path = '/tmp/premium/'+ str(rtc)
        print 'Your CTE package and related logs will be created at:\n', path,'\n'
        os.mkdir(path, 0755)

def import_into_SIT():


#############################################################

op = raw_input('Insert 1 to Import. Insert 2 to Export.\n')
if op.isdigit():
        if(op == '1'):
                print 'Import selected.\n'
        elif(op == '2'):
                print 'Export selected.\n'
                export_from_DEV()
        elif((op < 0) or (op > 2)):
                print 'Invalid Option, exiting.\n'
                sys.exit(0)
else:
        print 'Invalid Option, exiting. Only 1 or 2 are valid options, letters not.\n'
        sys.exit(0)

#path = '/tmp/sergio/'+ str(rtc)
#print path
#os.mkdir(path, 0755)

def import_into_sit():
        print 'Insert RTC number'
