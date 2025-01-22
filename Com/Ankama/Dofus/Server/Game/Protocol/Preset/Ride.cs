using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Preset
{
	// Token: 0x020001F3 RID: 499
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class Ride : IMessage<Ride>, IMessage, IEquatable<Ride>, IDeepCloneable<Ride>, IBufferMessage
	{
		// Token: 0x1700042B RID: 1067
		// (get) Token: 0x0600175F RID: 5983 RVA: 0x001AD5D8 File Offset: 0x001AB7D8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<Ride> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700042C RID: 1068
		// (get) Token: 0x06001760 RID: 5984 RVA: 0x001AD5E8 File Offset: 0x001AB7E8
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

		// Token: 0x1700042D RID: 1069
		// (get) Token: 0x06001761 RID: 5985 RVA: 0x001AD5F8 File Offset: 0x001AB7F8
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

		// Token: 0x06001762 RID: 5986 RVA: 0x001AD608 File Offset: 0x001AB808
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Ride()
		{
		}

		// Token: 0x06001763 RID: 5987 RVA: 0x001AD618 File Offset: 0x001AB818
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Ride(Ride other)
		{
		}

		// Token: 0x06001764 RID: 5988 RVA: 0x001AD628 File Offset: 0x001AB828
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Ride Clone()
		{
			return null;
		}

		// Token: 0x1700042E RID: 1070
		// (get) Token: 0x06001765 RID: 5989 RVA: 0x001AD638 File Offset: 0x001AB838
		// (set) Token: 0x06001766 RID: 5990 RVA: 0x001AD648 File Offset: 0x001AB848
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ModelId
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

		// Token: 0x1700042F RID: 1071
		// (get) Token: 0x06001767 RID: 5991 RVA: 0x001AD658 File Offset: 0x001AB858
		// (set) Token: 0x06001768 RID: 5992 RVA: 0x001AD668 File Offset: 0x001AB868
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int Level
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

		// Token: 0x17000430 RID: 1072
		// (get) Token: 0x06001769 RID: 5993 RVA: 0x001AD678 File Offset: 0x001AB878
		// (set) Token: 0x0600176A RID: 5994 RVA: 0x001AD688 File Offset: 0x001AB888
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool IsCurrentRide
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x0600176B RID: 5995 RVA: 0x001AD698 File Offset: 0x001AB898
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600176C RID: 5996 RVA: 0x001AD6A8 File Offset: 0x001AB8A8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(Ride other)
		{
			return true;
		}

		// Token: 0x0600176D RID: 5997 RVA: 0x001AD6B8 File Offset: 0x001AB8B8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600176E RID: 5998 RVA: 0x001AD6C8 File Offset: 0x001AB8C8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600176F RID: 5999 RVA: 0x001AD6D8 File Offset: 0x001AB8D8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06001770 RID: 6000 RVA: 0x001AD6E8 File Offset: 0x001AB8E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06001771 RID: 6001 RVA: 0x001AD6F8 File Offset: 0x001AB8F8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06001772 RID: 6002 RVA: 0x001AD708 File Offset: 0x001AB908
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(Ride other)
		{
		}

		// Token: 0x06001773 RID: 6003 RVA: 0x001AD718 File Offset: 0x001AB918
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06001774 RID: 6004 RVA: 0x001AD728 File Offset: 0x001AB928
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06001775 RID: 6005 RVA: 0x001AD738 File Offset: 0x001AB938
		[MethodImpl(MethodImplOptions.NoInlining)]
		static Ride()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 2;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_269bb7d2d6f34e31889f481450697ae9 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_46b15fddf6c94445bea2053db8105f1b == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					return;
				case 4:
					Ride._parser = new MessageParser<Ride>(() => null);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_08862c9eab7444c19558a8b548142851 == 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 3;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1f6ff9e2a68c42fc98201e1b3e077000 == 0)
				{
					num2 = 4;
				}
			}
		}

		// Token: 0x06001776 RID: 6006 RVA: 0x001AD830 File Offset: 0x001ABA30
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool wYu4uUO1MYXhH1Eor5SK()
		{
			return true;
		}

		// Token: 0x06001777 RID: 6007 RVA: 0x001AD838 File Offset: 0x001ABA38
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static Ride uUUwc7O1uForrfqvAdxE()
		{
			return null;
		}

		// Token: 0x0400085A RID: 2138
		private static readonly MessageParser<Ride> _parser;

		// Token: 0x0400085B RID: 2139
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400085C RID: 2140
		public const int ModelIdFieldNumber = 1;

		// Token: 0x0400085D RID: 2141
		private int modelId_;

		// Token: 0x0400085E RID: 2142
		public const int LevelFieldNumber = 2;

		// Token: 0x0400085F RID: 2143
		private int level_;

		// Token: 0x04000860 RID: 2144
		public const int IsCurrentRideFieldNumber = 3;

		// Token: 0x04000861 RID: 2145
		private bool isCurrentRide_;

		// Token: 0x04000862 RID: 2146
		internal static Ride U9GTI3O1SwtPD3XRfjUa;
	}
}
