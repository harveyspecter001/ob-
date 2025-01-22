using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Mount
{
	// Token: 0x0200037D RID: 893
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MountDataErrorEvent : IMessage<MountDataErrorEvent>, IMessage, IEquatable<MountDataErrorEvent>, IDeepCloneable<MountDataErrorEvent>, IBufferMessage
	{
		// Token: 0x1700077F RID: 1919
		// (get) Token: 0x060029F5 RID: 10741 RVA: 0x001C8650 File Offset: 0x001C6850
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MountDataErrorEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000780 RID: 1920
		// (get) Token: 0x060029F6 RID: 10742 RVA: 0x001C8660 File Offset: 0x001C6860
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

		// Token: 0x17000781 RID: 1921
		// (get) Token: 0x060029F7 RID: 10743 RVA: 0x001C8670 File Offset: 0x001C6870
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

		// Token: 0x060029F8 RID: 10744 RVA: 0x001C8680 File Offset: 0x001C6880
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MountDataErrorEvent()
		{
		}

		// Token: 0x060029F9 RID: 10745 RVA: 0x001C8690 File Offset: 0x001C6890
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MountDataErrorEvent(MountDataErrorEvent other)
		{
		}

		// Token: 0x060029FA RID: 10746 RVA: 0x001C86A0 File Offset: 0x001C68A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MountDataErrorEvent Clone()
		{
			return null;
		}

		// Token: 0x17000782 RID: 1922
		// (get) Token: 0x060029FB RID: 10747 RVA: 0x001C86B0 File Offset: 0x001C68B0
		// (set) Token: 0x060029FC RID: 10748 RVA: 0x001C86C4 File Offset: 0x001C68C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MountDataErrorEvent.Types.MountDataError Reason
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (MountDataErrorEvent.Types.MountDataError)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x060029FD RID: 10749 RVA: 0x001C86D4 File Offset: 0x001C68D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060029FE RID: 10750 RVA: 0x001C86E4 File Offset: 0x001C68E4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(MountDataErrorEvent other)
		{
			return true;
		}

		// Token: 0x060029FF RID: 10751 RVA: 0x001C86F4 File Offset: 0x001C68F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06002A00 RID: 10752 RVA: 0x001C8704 File Offset: 0x001C6904
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06002A01 RID: 10753 RVA: 0x001C8714 File Offset: 0x001C6914
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06002A02 RID: 10754 RVA: 0x001C8724 File Offset: 0x001C6924
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06002A03 RID: 10755 RVA: 0x001C8734 File Offset: 0x001C6934
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06002A04 RID: 10756 RVA: 0x001C8744 File Offset: 0x001C6944
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(MountDataErrorEvent other)
		{
		}

		// Token: 0x06002A05 RID: 10757 RVA: 0x001C8754 File Offset: 0x001C6954
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06002A06 RID: 10758 RVA: 0x001C8764 File Offset: 0x001C6964
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06002A07 RID: 10759 RVA: 0x001C8774 File Offset: 0x001C6974
		[MethodImpl(MethodImplOptions.NoInlining)]
		static MountDataErrorEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 1;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 3;
					break;
				case 1:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_5031fac8c16a43b8b5e515682df08cbd == 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					return;
				case 3:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 4;
					break;
				case 4:
					MountDataErrorEvent._parser = new MessageParser<MountDataErrorEvent>(() => null);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_21f5734de83f479ea303da2e5b23aa43 != 0)
					{
						num2 = 2;
					}
					break;
				}
			}
		}

		// Token: 0x06002A08 RID: 10760 RVA: 0x001C8840 File Offset: 0x001C6A40
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool FtYihLOrkU51lVZ5DumB()
		{
			return true;
		}

		// Token: 0x06002A09 RID: 10761 RVA: 0x001C8848 File Offset: 0x001C6A48
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static MountDataErrorEvent rEOBlQOrltAC1JjfFvP5()
		{
			return null;
		}

		// Token: 0x04000ED1 RID: 3793
		private static readonly MessageParser<MountDataErrorEvent> _parser;

		// Token: 0x04000ED2 RID: 3794
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000ED3 RID: 3795
		public const int ReasonFieldNumber = 1;

		// Token: 0x04000ED4 RID: 3796
		private MountDataErrorEvent.Types.MountDataError reason_;

		// Token: 0x04000ED5 RID: 3797
		internal static MountDataErrorEvent fsBZyJOrIpD6jWub8PoF;

		// Token: 0x0200037E RID: 894
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static class Types
		{
			// Token: 0x06002A0A RID: 10762 RVA: 0x002B966C File Offset: 0x002B786C
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Types()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x0200037F RID: 895
			public enum MountDataError
			{
				// Token: 0x04000ED7 RID: 3799
				[OriginalName("UNKNOWN")]
				Unknown,
				// Token: 0x04000ED8 RID: 3800
				[OriginalName("NOT_FOUND")]
				NotFound,
				// Token: 0x04000ED9 RID: 3801
				[OriginalName("SOMEONE_ELSE_PRIVATE_FARM")]
				SomeoneElsePrivateFarm,
				// Token: 0x04000EDA RID: 3802
				[OriginalName("SOMEONE_ELSE_MOUNT")]
				SomeoneElseMount
			}
		}
	}
}
