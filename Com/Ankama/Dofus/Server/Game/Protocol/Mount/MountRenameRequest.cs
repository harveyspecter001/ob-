using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Mount
{
	// Token: 0x02000361 RID: 865
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MountRenameRequest : IMessage<MountRenameRequest>, IMessage, IEquatable<MountRenameRequest>, IDeepCloneable<MountRenameRequest>, IBufferMessage
	{
		// Token: 0x17000746 RID: 1862
		// (get) Token: 0x06002898 RID: 10392 RVA: 0x001C6B00 File Offset: 0x001C4D00
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<MountRenameRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000747 RID: 1863
		// (get) Token: 0x06002899 RID: 10393 RVA: 0x001C6B10 File Offset: 0x001C4D10
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000748 RID: 1864
		// (get) Token: 0x0600289A RID: 10394 RVA: 0x001C6B20 File Offset: 0x001C4D20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x0600289B RID: 10395 RVA: 0x001C6B30 File Offset: 0x001C4D30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MountRenameRequest()
		{
		}

		// Token: 0x0600289C RID: 10396 RVA: 0x001C6B40 File Offset: 0x001C4D40
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MountRenameRequest(MountRenameRequest other)
		{
		}

		// Token: 0x0600289D RID: 10397 RVA: 0x001C6B50 File Offset: 0x001C4D50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MountRenameRequest Clone()
		{
			return null;
		}

		// Token: 0x17000749 RID: 1865
		// (get) Token: 0x0600289E RID: 10398 RVA: 0x001C6B60 File Offset: 0x001C4D60
		// (set) Token: 0x0600289F RID: 10399 RVA: 0x001C6B70 File Offset: 0x001C4D70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Name
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x1700074A RID: 1866
		// (get) Token: 0x060028A0 RID: 10400 RVA: 0x001C6B80 File Offset: 0x001C4D80
		// (set) Token: 0x060028A1 RID: 10401 RVA: 0x001C6B90 File Offset: 0x001C4D90
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

		// Token: 0x060028A2 RID: 10402 RVA: 0x001C6BA0 File Offset: 0x001C4DA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060028A3 RID: 10403 RVA: 0x001C6BB0 File Offset: 0x001C4DB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(MountRenameRequest other)
		{
			return true;
		}

		// Token: 0x060028A4 RID: 10404 RVA: 0x001C6BC0 File Offset: 0x001C4DC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060028A5 RID: 10405 RVA: 0x001C6BD0 File Offset: 0x001C4DD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060028A6 RID: 10406 RVA: 0x001C6BE0 File Offset: 0x001C4DE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060028A7 RID: 10407 RVA: 0x001C6BF0 File Offset: 0x001C4DF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060028A8 RID: 10408 RVA: 0x001C6C00 File Offset: 0x001C4E00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060028A9 RID: 10409 RVA: 0x001C6C10 File Offset: 0x001C4E10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(MountRenameRequest other)
		{
		}

		// Token: 0x060028AA RID: 10410 RVA: 0x001C6C20 File Offset: 0x001C4E20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060028AB RID: 10411 RVA: 0x001C6C30 File Offset: 0x001C4E30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060028AC RID: 10412 RVA: 0x001C6C40 File Offset: 0x001C4E40
		[MethodImpl(MethodImplOptions.NoInlining)]
		static MountRenameRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 2;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_edbfdc8f17624ec69b7969ca8a81ad59 == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 2:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_9bf8e3bf2cc345d6a23caabc34a1f0d0 == 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					case 3:
						MountRenameRequest._parser = new MessageParser<MountRenameRequest>(() => null);
						num2 = 4;
						continue;
					case 4:
						return;
					}
					break;
				}
				IL_AB:
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num = 3;
				continue;
				goto IL_AB;
			}
		}

		// Token: 0x060028AD RID: 10413 RVA: 0x001C6D10 File Offset: 0x001C4F10
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool OKkteJOhT3xx0vmlgn3e()
		{
			return true;
		}

		// Token: 0x060028AE RID: 10414 RVA: 0x001C6D18 File Offset: 0x001C4F18
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static MountRenameRequest WBTrEvOhpLHK7OCt2Gr5()
		{
			return null;
		}

		// Token: 0x04000E67 RID: 3687
		private static readonly MessageParser<MountRenameRequest> _parser;

		// Token: 0x04000E68 RID: 3688
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000E69 RID: 3689
		public const int NameFieldNumber = 1;

		// Token: 0x04000E6A RID: 3690
		private string name_;

		// Token: 0x04000E6B RID: 3691
		public const int MountIdFieldNumber = 2;

		// Token: 0x04000E6C RID: 3692
		private int mountId_;

		// Token: 0x04000E6D RID: 3693
		internal static MountRenameRequest LuegEwOh7FlaslJp451U;
	}
}
