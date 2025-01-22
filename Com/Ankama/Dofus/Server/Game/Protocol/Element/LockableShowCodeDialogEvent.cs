using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Element
{
	// Token: 0x020007D0 RID: 2000
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class LockableShowCodeDialogEvent : IMessage<LockableShowCodeDialogEvent>, IMessage, IEquatable<LockableShowCodeDialogEvent>, IDeepCloneable<LockableShowCodeDialogEvent>, IBufferMessage
	{
		// Token: 0x170011C4 RID: 4548
		// (get) Token: 0x060061F6 RID: 25078 RVA: 0x00222138 File Offset: 0x00220338
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<LockableShowCodeDialogEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170011C5 RID: 4549
		// (get) Token: 0x060061F7 RID: 25079 RVA: 0x00222148 File Offset: 0x00220348
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

		// Token: 0x170011C6 RID: 4550
		// (get) Token: 0x060061F8 RID: 25080 RVA: 0x00222158 File Offset: 0x00220358
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

		// Token: 0x060061F9 RID: 25081 RVA: 0x00222168 File Offset: 0x00220368
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public LockableShowCodeDialogEvent()
		{
		}

		// Token: 0x060061FA RID: 25082 RVA: 0x00222178 File Offset: 0x00220378
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public LockableShowCodeDialogEvent(LockableShowCodeDialogEvent other)
		{
		}

		// Token: 0x060061FB RID: 25083 RVA: 0x00222188 File Offset: 0x00220388
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public LockableShowCodeDialogEvent Clone()
		{
			return null;
		}

		// Token: 0x170011C7 RID: 4551
		// (get) Token: 0x060061FC RID: 25084 RVA: 0x00222198 File Offset: 0x00220398
		// (set) Token: 0x060061FD RID: 25085 RVA: 0x002221AC File Offset: 0x002203AC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public LockableShowCodeDialogEvent.Types.Action Action
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (LockableShowCodeDialogEvent.Types.Action)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x170011C8 RID: 4552
		// (get) Token: 0x060061FE RID: 25086 RVA: 0x002221BC File Offset: 0x002203BC
		// (set) Token: 0x060061FF RID: 25087 RVA: 0x002221CC File Offset: 0x002203CC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int CodeSize
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

		// Token: 0x06006200 RID: 25088 RVA: 0x002221DC File Offset: 0x002203DC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06006201 RID: 25089 RVA: 0x002221EC File Offset: 0x002203EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(LockableShowCodeDialogEvent other)
		{
			return true;
		}

		// Token: 0x06006202 RID: 25090 RVA: 0x002221FC File Offset: 0x002203FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06006203 RID: 25091 RVA: 0x0022220C File Offset: 0x0022040C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06006204 RID: 25092 RVA: 0x0022221C File Offset: 0x0022041C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06006205 RID: 25093 RVA: 0x0022222C File Offset: 0x0022042C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06006206 RID: 25094 RVA: 0x0022223C File Offset: 0x0022043C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06006207 RID: 25095 RVA: 0x0022224C File Offset: 0x0022044C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(LockableShowCodeDialogEvent other)
		{
		}

		// Token: 0x06006208 RID: 25096 RVA: 0x0022225C File Offset: 0x0022045C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06006209 RID: 25097 RVA: 0x0022226C File Offset: 0x0022046C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600620A RID: 25098 RVA: 0x0022227C File Offset: 0x0022047C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static LockableShowCodeDialogEvent()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3e220445ad264b8fac4b36b1feaab002 != 0)
					{
						num2 = 2;
					}
					break;
				case 1:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_5a311387d93b4062966e90581a8a80b2 != 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					LockableShowCodeDialogEvent._parser = new MessageParser<LockableShowCodeDialogEvent>(() => null);
					num2 = 4;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_0cf81502393c4abba92bedafaef205c1 != 0)
					{
						num2 = 4;
					}
					break;
				case 3:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_7dffff2eb1b849cc96c1b1e17cd952bf != 0)
					{
						num2 = 2;
					}
					break;
				case 4:
					return;
				}
			}
		}

		// Token: 0x0600620B RID: 25099 RVA: 0x00222374 File Offset: 0x00220574
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool YWBPG0OFl2iIuFCtUrY5()
		{
			return true;
		}

		// Token: 0x0600620C RID: 25100 RVA: 0x0022237C File Offset: 0x0022057C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static LockableShowCodeDialogEvent ci0LunOFcJVdp3Ufp3RJ()
		{
			return null;
		}

		// Token: 0x0400226F RID: 8815
		private static readonly MessageParser<LockableShowCodeDialogEvent> _parser;

		// Token: 0x04002270 RID: 8816
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002271 RID: 8817
		public const int ActionFieldNumber = 1;

		// Token: 0x04002272 RID: 8818
		private LockableShowCodeDialogEvent.Types.Action action_;

		// Token: 0x04002273 RID: 8819
		public const int CodeSizeFieldNumber = 2;

		// Token: 0x04002274 RID: 8820
		private int codeSize_;

		// Token: 0x04002275 RID: 8821
		private static LockableShowCodeDialogEvent ToO3xSOFkmkgvumpqpIg;

		// Token: 0x020007D1 RID: 2001
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static class Types
		{
			// Token: 0x0600620D RID: 25101 RVA: 0x002D36B0 File Offset: 0x002D18B0
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Types()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x020007D2 RID: 2002
			public enum Action
			{
				// Token: 0x04002277 RID: 8823
				[OriginalName("CHANGE")]
				Change,
				// Token: 0x04002278 RID: 8824
				[OriginalName("USE")]
				Use
			}
		}
	}
}
