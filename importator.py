import os, sys
########notes for development:
#create for each operation a dedicated config file
#config_file = open('myfile.dat', 'w+')
#make the changes
#flush to commit

###########SOME FUNCTIONS###################################
def premium_folder():
        if not os.path.exists('/tmp/premium/'):
        #       print '/tmp/premium folder not exists, -not a problem, creating and proceeding...\n'
                os.makedirs('/tmp/premium/')

def export_from_DEV():
        rtc = raw_input('Insert RTC number\n')
        path = '/tmp/premium/'+ str(rtc)
        print 'Your CTE package and related logs will be created at:\n', path,'\n'
        os.mkdir(path, 0755)

def export_from_SIT():
        rtc = raw_input('Insert RTC number\n')
        path = '/tmp/premium/'+ str(rtc)
        print 'Your CTE package and related logs will be created at:\n', path,'\n'
        os.mkdir(path, 0755)

def import_into_SIT():
        print 'Import into sit function called'

########################################################################################

#lets get the task:
op = raw_input('Insert:\n1 to Import into SIT.\n2 to Export from DEV.\n3 to Export from SIT.\n')

#lets make sure that premium folder exists under /tmp
premium_folder()

#based on choice lets call the function:
if op.isdigit():
        if(op == '1'):
                print 'Import selected.\n'
                import_into_SIT()

        elif(op == '2'):
                print 'Export from DEV selected.\n'
                export_from_DEV()

        elif(op == '3'):
                print 'Export from SIT selected.\n'
                export_from_SIT()

        elif((op < 0) or (op > 2)):
                print 'Invalid Option, exiting.\n'
                sys.exit(0)
else:
        print 'Invalid Option, exiting. Only 1, 2 and 3 are valid options, letters not.\n'
        sys.exit(0)
