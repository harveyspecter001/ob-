using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Mount
{
	// Token: 0x0200038B RID: 907
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MountEmoteIconUsedEvent : IMessage<MountEmoteIconUsedEvent>, IMessage, IEquatable<MountEmoteIconUsedEvent>, IDeepCloneable<MountEmoteIconUsedEvent>, IBufferMessage
	{
		// Token: 0x17000792 RID: 1938
		// (get) Token: 0x06002A77 RID: 10871 RVA: 0x001C9088 File Offset: 0x001C7288
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<MountEmoteIconUsedEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000793 RID: 1939
		// (get) Token: 0x06002A78 RID: 10872 RVA: 0x001C9098 File Offset: 0x001C7298
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000794 RID: 1940
		// (get) Token: 0x06002A79 RID: 10873 RVA: 0x001C90A8 File Offset: 0x001C72A8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x06002A7A RID: 10874 RVA: 0x001C90B8 File Offset: 0x001C72B8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MountEmoteIconUsedEvent()
		{
		}

		// Token: 0x06002A7B RID: 10875 RVA: 0x001C90C8 File Offset: 0x001C72C8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MountEmoteIconUsedEvent(MountEmoteIconUsedEvent other)
		{
		}

		// Token: 0x06002A7C RID: 10876 RVA: 0x001C90D8 File Offset: 0x001C72D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MountEmoteIconUsedEvent Clone()
		{
			return null;
		}

		// Token: 0x17000795 RID: 1941
		// (get) Token: 0x06002A7D RID: 10877 RVA: 0x001C90E8 File Offset: 0x001C72E8
		// (set) Token: 0x06002A7E RID: 10878 RVA: 0x001C90F8 File Offset: 0x001C72F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MountId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return 0;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x17000796 RID: 1942
		// (get) Token: 0x06002A7F RID: 10879 RVA: 0x001C9108 File Offset: 0x001C7308
		// (set) Token: 0x06002A80 RID: 10880 RVA: 0x001C9118 File Offset: 0x001C7318
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Reaction
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return 0;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x06002A81 RID: 10881 RVA: 0x001C9128 File Offset: 0x001C7328
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06002A82 RID: 10882 RVA: 0x001C9138 File Offset: 0x001C7338
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(MountEmoteIconUsedEvent other)
		{
			return true;
		}

		// Token: 0x06002A83 RID: 10883 RVA: 0x001C9148 File Offset: 0x001C7348
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06002A84 RID: 10884 RVA: 0x001C9158 File Offset: 0x001C7358
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06002A85 RID: 10885 RVA: 0x001C9168 File Offset: 0x001C7368
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06002A86 RID: 10886 RVA: 0x001C9178 File Offset: 0x001C7378
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06002A87 RID: 10887 RVA: 0x001C9188 File Offset: 0x001C7388
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06002A88 RID: 10888 RVA: 0x001C9198 File Offset: 0x001C7398
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(MountEmoteIconUsedEvent other)
		{
		}

		// Token: 0x06002A89 RID: 10889 RVA: 0x001C91A8 File Offset: 0x001C73A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06002A8A RID: 10890 RVA: 0x001C91B8 File Offset: 0x001C73B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06002A8B RID: 10891 RVA: 0x001C91C8 File Offset: 0x001C73C8
		[MethodImpl(MethodImplOptions.NoInlining)]
		static MountEmoteIconUsedEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b13adc788c2b4a3ba01ee25b354c05a3 == 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 2:
					MountEmoteIconUsedEvent._parser = new MessageParser<MountEmoteIconUsedEvent>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3a65ba0257d143fcafc38c637bf110f5 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_fdbe83fcafda431197ae585ab85635a6 != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 3;
					continue;
				}
				break;
			}
		}

		// Token: 0x06002A8C RID: 10892 RVA: 0x001C92AC File Offset: 0x001C74AC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool eVK6r6OrVbXrlup4VeSa()
		{
			return true;
		}

		// Token: 0x06002A8D RID: 10893 RVA: 0x001C92B4 File Offset: 0x001C74B4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static MountEmoteIconUsedEvent cunxRhOr03x0iKxHqX3A()
		{
			return null;
		}

		// Token: 0x04000EFB RID: 3835
		private static readonly MessageParser<MountEmoteIconUsedEvent> _parser;

		// Token: 0x04000EFC RID: 3836
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000EFD RID: 3837
		public const int MountIdFieldNumber = 1;

		// Token: 0x04000EFE RID: 3838
		private int mountId_;

		// Token: 0x04000EFF RID: 3839
		public const int ReactionFieldNumber = 2;

		// Token: 0x04000F00 RID: 3840
		private int reaction_;

		// Token: 0x04000F01 RID: 3841
		internal static MountEmoteIconUsedEvent AENbBIOrrcyK42na97DI;
	}
}
