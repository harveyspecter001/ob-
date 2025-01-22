using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Alliance.Information
{
	// Token: 0x02000D72 RID: 3442
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AllianceMotdEvent : IMessage<AllianceMotdEvent>, IMessage, IEquatable<AllianceMotdEvent>, IDeepCloneable<AllianceMotdEvent>, IBufferMessage
	{
		// Token: 0x17001ED2 RID: 7890
		// (get) Token: 0x0600A5E7 RID: 42471 RVA: 0x0029121C File Offset: 0x0028F41C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<AllianceMotdEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001ED3 RID: 7891
		// (get) Token: 0x0600A5E8 RID: 42472 RVA: 0x0029122C File Offset: 0x0028F42C
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

		// Token: 0x17001ED4 RID: 7892
		// (get) Token: 0x0600A5E9 RID: 42473 RVA: 0x0029123C File Offset: 0x0028F43C
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

		// Token: 0x0600A5EA RID: 42474 RVA: 0x0029124C File Offset: 0x0028F44C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceMotdEvent()
		{
		}

		// Token: 0x0600A5EB RID: 42475 RVA: 0x0029125C File Offset: 0x0028F45C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceMotdEvent(AllianceMotdEvent other)
		{
		}

		// Token: 0x0600A5EC RID: 42476 RVA: 0x0029126C File Offset: 0x0028F46C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceMotdEvent Clone()
		{
			return null;
		}

		// Token: 0x17001ED5 RID: 7893
		// (get) Token: 0x0600A5ED RID: 42477 RVA: 0x0029127C File Offset: 0x0028F47C
		// (set) Token: 0x0600A5EE RID: 42478 RVA: 0x0029128C File Offset: 0x0028F48C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SocialNoticeInformation MotdInfo
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

		// Token: 0x0600A5EF RID: 42479 RVA: 0x0029129C File Offset: 0x0028F49C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600A5F0 RID: 42480 RVA: 0x002912AC File Offset: 0x0028F4AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(AllianceMotdEvent other)
		{
			return true;
		}

		// Token: 0x0600A5F1 RID: 42481 RVA: 0x002912BC File Offset: 0x0028F4BC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600A5F2 RID: 42482 RVA: 0x002912CC File Offset: 0x0028F4CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600A5F3 RID: 42483 RVA: 0x002912DC File Offset: 0x0028F4DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600A5F4 RID: 42484 RVA: 0x002912EC File Offset: 0x0028F4EC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600A5F5 RID: 42485 RVA: 0x002912FC File Offset: 0x0028F4FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600A5F6 RID: 42486 RVA: 0x0029130C File Offset: 0x0028F50C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(AllianceMotdEvent other)
		{
		}

		// Token: 0x0600A5F7 RID: 42487 RVA: 0x0029131C File Offset: 0x0028F51C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600A5F8 RID: 42488 RVA: 0x0029132C File Offset: 0x0028F52C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600A5F9 RID: 42489 RVA: 0x0029133C File Offset: 0x0028F53C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static AllianceMotdEvent()
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
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3c5b82ca766c4792853da62b3454c783 != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_de04fdfebdbd4a719a239c73a4c6f026 != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 4;
					continue;
				case 4:
					AllianceMotdEvent._parser = new MessageParser<AllianceMotdEvent>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_d4f27f93537d433bbe27f32ad7c99329 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				break;
			}
		}

		// Token: 0x0600A5FA RID: 42490 RVA: 0x00291420 File Offset: 0x0028F620
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool tVfydJJkWrgX0IuuZjT0()
		{
			return true;
		}

		// Token: 0x0600A5FB RID: 42491 RVA: 0x00291428 File Offset: 0x0028F628
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static AllianceMotdEvent I3bx2KJkhAapvfbwgWRt()
		{
			return null;
		}

		// Token: 0x04003D2B RID: 15659
		private static readonly MessageParser<AllianceMotdEvent> _parser;

		// Token: 0x04003D2C RID: 15660
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003D2D RID: 15661
		public const int MotdInfoFieldNumber = 1;

		// Token: 0x04003D2E RID: 15662
		private SocialNoticeInformation motdInfo_;

		// Token: 0x04003D2F RID: 15663
		internal static AllianceMotdEvent aLuUmvJkLB0gXOhIEOg4;
	}
}
